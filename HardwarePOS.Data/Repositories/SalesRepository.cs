using Dapper;
using HardwarePOS.Data.Database;
using System.Data;


namespace HardwarePOS.Data.Repositories
{
    public class SalesRepository
    {
        private readonly DbConnectionFactory _factory;

        public SalesRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<string> GetNextSalesNoAsync()
        {
            using var connection = _factory.CreateConnection();

            return await connection.ExecuteScalarAsync<string>("sp_GetNextSalesNo", commandType: CommandType.StoredProcedure);
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
        public async Task<int> SaveSalesAsync(SalesHeader sales)
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

            foreach (var item in sales.Items)
            {
                table.Rows.Add(
                    item.ProductId,
                    item.CategoryId,
                    item.UnitId,
                    item.SellingPrice,
                    item.GrossWeight,
                    item.TareWeight,
                    item.WetWeight,
                    item.NetWeight,
                    item.TotalPrice
                );
            }

            var parameters = new DynamicParameters();

            parameters.Add("@InvoiceNumber", sales.InvoiceNumber);
            parameters.Add("@SaleDate", sales.SaleDate);
            parameters.Add("@CustomerId", sales.CustomerId);
            parameters.Add("@GrandTotal", sales.GrandTotal);
            parameters.Add("@PaidAmount", sales.PaidAmount);
            parameters.Add("@BalanceAmount", sales.BalanceAmount);
            parameters.Add("@Remarks", sales.Remarks);
            parameters.Add("@CreatedBy", sales.CreatedBy);
            parameters.Add("@DaySessionId", sales.DaySessionId);

            parameters.Add(
                "@Items",
                table.AsTableValuedParameter("SalesDetailType")
            );

            return await connection.ExecuteScalarAsync<int>("sp_Sales_Save",parameters,commandType: CommandType.StoredProcedure
            );
        }

    }


    }


