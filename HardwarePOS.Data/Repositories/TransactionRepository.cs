using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.Entities;
using System.Data;

namespace HardwarePOS.Data.Repositories
{
    public class TransactionRepository 
    {
        private readonly DbConnectionFactory _factory;

        public TransactionRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<List<TransactionHistory>> GetTransactionsAsync(string? type, DateTime? fromDate, DateTime? toDate, string? search)
        {
            using var connection = _factory.CreateConnection();

            const string sql = @"
                            SELECT
                                SH.SalesId AS Id,
                                'SALE' AS TransactionType,
                                SH.InvoiceNumber AS InvoiceNo,
                                SH.SaleDate AS TransactionDate,
                                SH.TotalAmount,
                                SH.PaymentMethod,
                                SH.PaidAmount,
                                SH.BalanceAmount,
                                SH.Status,
                                ST.FullName AS CreatedBy

                            FROM SalesHeader SH
                            INNER JOIN Staff ST
                                ON ST.StaffId = SH.CreatedBy

                            WHERE
                            (
                                @Type IS NULL
                                OR @Type = ''
                                OR @Type = 'ALL'
                                OR @Type = 'SALE'
                            )
                            AND
                            (
                                @FromDate IS NULL
                                OR CAST(SH.SaleDate AS DATE) >= @FromDate
                            )
                            AND
                            (
                                @ToDate IS NULL
                                OR CAST(SH.SaleDate AS DATE) <= @ToDate
                            )
                            AND
                            (
                                @Search IS NULL
                                OR @Search = ''
                                OR SH.InvoiceNumber LIKE '%' + @Search + '%'
                            )

                            UNION ALL

                            SELECT
                                PH.PurchaseId AS Id,
                                'PURCHASE' AS TransactionType,
                                PH.PurchaseNo AS InvoiceNo,
                                PH.PurchaseDate AS TransactionDate,
                                PH.GrandTotal AS TotalAmount,
                                PH.PaymentMethod,
                                PH.PaidAmount,
                                PH.BalanceAmount,
                                PH.Status,
                                ST.FullName AS CreatedBy

                            FROM PurchaseHeader PH
                            INNER JOIN Staff ST
                                ON ST.StaffId = PH.CreatedBy

                            WHERE
                            (
                                @Type IS NULL
                                OR @Type = ''
                                OR @Type = 'ALL'
                                OR @Type = 'PURCHASE'
                            )
                            AND
                            (
                                @FromDate IS NULL
                                OR CAST(PH.PurchaseDate AS DATE) >= @FromDate
                            )
                            AND
                            (
                                @ToDate IS NULL
                                OR CAST(PH.PurchaseDate AS DATE) <= @ToDate
                            )
                            AND
                            (
                                @Search IS NULL
                                OR @Search = ''
                                OR PH.PurchaseNo LIKE '%' + @Search + '%'
                            )

                            ORDER BY TransactionDate DESC;";

            var result = await connection.QueryAsync<TransactionHistory>(sql, new{Type = type, FromDate = fromDate, ToDate = toDate, Search = search});

            return result.ToList();
        }

        public async Task<bool> VoidTransactionAsync(string transactionType, int transactionId, int cancelledBy, string cancelReason)
        {
            using var connection = _factory.CreateConnection();

            var parameters = new
            {
                TransactionType = transactionType,
                TransactionId = transactionId,
                CancelledBy = cancelledBy,
                CancelReason = cancelReason
            };

            await connection.ExecuteAsync("sp_VoidTransaction", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}