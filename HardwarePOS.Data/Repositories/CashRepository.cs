using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.Entities;
using System.Data;

namespace HardwarePOS.Data.Repositories
{
    public class CashRepository 
    {
        private readonly DbConnectionFactory _factory;

        public CashRepository(DbConnectionFactory factory)
        {
            _factory = factory;
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

        public async Task<int> SaveAsync(CashTransaction cash)
        {
            using var connection = _factory.CreateConnection();

            var parameters = new DynamicParameters();

            parameters.Add("@TransactionDate", cash.TransactionDate);
            parameters.Add("@TransactionType", cash.TransactionType);
            parameters.Add("@Category", cash.Category);
            parameters.Add("@Amount", cash.Amount);
            parameters.Add("@ReferenceNo", cash.ReferenceNo);
            parameters.Add("@Remarks", cash.Remarks);
            parameters.Add("@CreatedBy", cash.CreatedBy);
            parameters.Add("@DaySessionId", cash.DaySessionId);

            return await connection.ExecuteScalarAsync<int>("sp_CashTransaction_Save",parameters,commandType: CommandType.StoredProcedure);
        }

        public async Task<decimal> GetCurrentCashAsync(int daySessionId)
        {
            using var connection = _factory.CreateConnection();

            const string sql = @"
        SELECT
            ISNULL(ds.OpeningCash, 0)
            +
            ISNULL
            (
                (
                    SELECT SUM(Amount)
                    FROM CashTransaction
                    WHERE DaySessionId = ds.DaySessionId
                    AND TransactionType = 'CASH_IN'
                ), 0
            )
            -
            ISNULL
            (
                (
                    SELECT SUM(Amount)
                    FROM CashTransaction
                    WHERE DaySessionId = ds.DaySessionId
                    AND TransactionType = 'CASH_OUT'
                ), 0
            ) AS CurrentCash
        FROM DaySession ds
        WHERE ds.DaySessionId = @daySessionId;";

            return await connection.ExecuteScalarAsync<decimal>(
                sql,
                new { daySessionId });
        }

        public async Task<List<CashTransaction>> GetCashFlowAsync(string? transactionType,DateTime? fromDate,DateTime? toDate,string? search)
        {
            using var connection = _factory.CreateConnection();

            const string sql = @"


SELECT
    ct.CashTransactionId,
    ct.TransactionDate,
    ct.TransactionType,
    ct.Category,
    ct.Amount,
    ct.ReferenceNo,
    ct.Remarks,

    ct.CreatedBy,
    s.FullName AS CreatedByName,

    ds.OpenDateTime AS DaySessionDate

FROM CashTransaction ct

INNER JOIN Staff s
    ON s.StaffId = ct.CreatedBy

INNER JOIN DaySession ds
    ON ds.DaySessionId = ct.DaySessionId

WHERE
(
    @transactionType IS NULL
    OR @transactionType = ''
    OR ct.TransactionType = @transactionType
)

AND
(
    @fromDate IS NULL
    OR CAST(ct.TransactionDate AS DATE) >= @fromDate
)

AND
(
    @toDate IS NULL
    OR CAST(ct.TransactionDate AS DATE) <= @toDate
)

AND
(
    @search IS NULL
    OR @search = ''
    OR ct.ReferenceNo LIKE '%' + @search + '%'
    OR ct.Category LIKE '%' + @search + '%'
    OR ct.Remarks LIKE '%' + @search + '%'
)

ORDER BY ct.TransactionDate DESC;";

            var result = await connection.QueryAsync<CashTransaction>(
                sql,
                new
                {
                    transactionType,
                    fromDate,
                    toDate,
                    search
                });

            return result.ToList();
        }
    }
}