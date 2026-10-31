using Dapper;
using HardwarePOS.Data.Database;
using System.Data;


namespace HardwarePOS.Data.Repositories
{
    public class PurchaseRepository
    {
        private readonly DbConnectionFactory _factory;

        public PurchaseRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<string> GetNextPurchaseNoAsync()
        {
            using var connection = _factory.CreateConnection();

            return await connection.ExecuteScalarAsync<string>("sp_GetNextPurchaseNo", commandType: CommandType.StoredProcedure);
        }

        public async Task<int> GetDaySesstion()
        {
            using var connection = _factory.CreateConnection();
            const string sql = @"
                                SELECT TOP (1) 
                                DaySessionId
                            FROM DaySession
                            ORDER BY DaySessionId DESC;";

            return await connection.ExecuteScalarAsync<int>(sql);
        }


        public async Task<int> SavePurchaseAsync(PurchaseHeader purchase)
        {
            using var connection = _factory.CreateConnection();

            var table = new DataTable();

            table.Columns.Add("ProductId", typeof(int));
            table.Columns.Add("CategoryId", typeof(int));
            table.Columns.Add("UnitId", typeof(int));
            table.Columns.Add("PurchasePrice", typeof(decimal));
            table.Columns.Add("GrossWeight", typeof(decimal));
            table.Columns.Add("TareWeight", typeof(decimal));
            table.Columns.Add("WetWeight", typeof(decimal));
            table.Columns.Add("NetWeight", typeof(decimal));
            table.Columns.Add("TotalPrice", typeof(decimal));

            foreach (var item in purchase.Items)
            {
                table.Rows.Add(
                    item.ProductId,
                    item.CategoryId,
                    item.UnitId,
                    item.PurchasePrice,
                    item.GrossWeight,
                    item.TareWeight,
                    item.WetWeight,
                    item.NetWeight,
                    item.TotalPrice
                );
            }

            var parameters = new DynamicParameters();

            parameters.Add("@PurchaseNo", purchase.PurchaseNo);
            parameters.Add("@PurchaseDate", purchase.PurchaseDate);
            parameters.Add("@SupplierId", purchase.SupplierId);
            parameters.Add("@GrandTotal", purchase.GrandTotal);
            parameters.Add("@PaidAmount", purchase.PaidAmount);
            parameters.Add("@BalanceAmount", purchase.BalanceAmount);
            parameters.Add("@Remarks", purchase.Remarks);
            parameters.Add("@CreatedBy", purchase.CreatedBy);
            parameters.Add("@DaySessionId", purchase.DaySessionId);

            parameters.Add(
                "@Items",
                table.AsTableValuedParameter("PurchaseDetailType")
            );

            return await connection.ExecuteScalarAsync<int>(
                "sp_Purchase_Save",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }

    }


    }


