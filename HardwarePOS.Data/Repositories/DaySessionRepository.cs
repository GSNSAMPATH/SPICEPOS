using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.DTOs;

namespace HardwarePOS.Data.Repositories
{
    public class DaySessionRepository
    {
        private readonly DbConnectionFactory _factory;

        public DaySessionRepository(
            DbConnectionFactory factory)
        {
            _factory = factory;
        }

        // ==========================================
        // GET CURRENT OPEN SESSION
        // ==========================================

        public async Task<DaySessionDto?>
            GetOpenSessionAsync()
        {
            using var connection =
                _factory.CreateConnection();

            const string sql = @"
                SELECT TOP 1
                    DaySessionId,
                    OpenDateTime,
                    CloseDateTime,
                    OpeningCash,
                    ClosingCash,
                    ExpectedCash,
                    CashDifference,
                    Status,
                    OpenedBy,
                    ClosedBy
                FROM DaySession
                WHERE Status = 'Open'
                ORDER BY DaySessionId DESC;";

            return await connection
                .QueryFirstOrDefaultAsync<DaySessionDto>(
                    sql);
        }

        // ==========================================
        // CHECK IF DAY IS OPEN
        // ==========================================

        public async Task<bool> IsDayOpenAsync()
        {
            using var connection =
                _factory.CreateConnection();

            const string sql = @"
                SELECT CASE
                    WHEN EXISTS
                    (
                        SELECT 1
                        FROM DaySession
                        WHERE Status = 'Open'
                    )
                    THEN CAST(1 AS BIT)
                    ELSE CAST(0 AS BIT)
                END;";

            return await connection
                .ExecuteScalarAsync<bool>(sql);
        }

        // ==========================================
        // START DAY
        // ==========================================

        public async Task<int> StartDayAsync(
            decimal openingCash,
            int userId)
        {
            using var connection =
                _factory.CreateConnection();

            const string sql = @"

                IF EXISTS
                (
                    SELECT 1
                    FROM DaySession
                    WHERE Status = 'Open'
                )
                BEGIN
                    THROW 50001,
                    'A business day is already open.',
                    1;
                END;

                INSERT INTO DaySession
                (
                    OpenDateTime,
                    OpeningCash,
                    Status,
                    OpenedBy
                )
                VALUES
                (
                    GETDATE(),
                    @OpeningCash,
                    'Open',
                    @UserId
                );

                SELECT CAST(
                    SCOPE_IDENTITY() AS INT);";

            return await connection
                .ExecuteScalarAsync<int>(
                    sql,
                    new
                    {
                        OpeningCash = openingCash,
                        UserId = userId
                    });
        }

        // ==========================================
        // GET CLOSING SUMMARY
        // ==========================================

        public async Task<DayClosingSummaryDto> GetClosingSummaryAsync(
          int daySessionId)
        {
            using var connection = _factory.CreateConnection();

            const string sql = @"
        SELECT
            DS.DaySessionId,
            ISNULL(DS.OpeningCash, 0) AS OpeningCash,

            -- Cash Sales
            ISNULL(
                (
                    SELECT SUM(SH.PaidAmount)
                    FROM SalesHeader SH
                    WHERE SH.DaySessionId = DS.DaySessionId
                      AND LOWER(SH.PaymentMethod) = 'cash'
                      AND ISNULL(Status, 'COMPLETED') <> 'VOIDED'
                ),
                0
            ) AS CashSales,

            -- Cash Purchase Payments
            ISNULL(
                (
                    SELECT SUM(PH.PaidAmount)
                    FROM PurchaseHeader PH
                    WHERE PH.DaySessionId = DS.DaySessionId
                      AND LOWER(PH.PaymentMethod) = 'cash'
                      AND ISNULL(Status, 'COMPLETED') <> 'VOIDED'
                ),
                0
            ) AS PurchasePayments,

            -- Cash In
            (
                SELECT ISNULL(SUM(CT.Amount), 0)
                FROM CashTransaction CT
                WHERE CT.DaySessionId = DS.DaySessionId
                  AND CT.TransactionType = 'CASH_IN'
                  AND CT.Category <> 'Purchase Void' AND  CT.Category <> 'Sale Income'
            ) AS CashIn,

            -- Cash Out
            (
                SELECT ISNULL(SUM(CT.Amount), 0)
                FROM CashTransaction CT
                WHERE CT.DaySessionId = DS.DaySessionId
                  AND CT.TransactionType = 'CASH_OUT'
                  AND CT.Category <> 'Sale Void' AND  CT.Category <> 'Supplier Purchase'
            ) AS CashOut,

            -- Expected Cash
            (
                ISNULL(DS.OpeningCash, 0)

                +

                ISNULL
                (
                    (
                        SELECT SUM(CT.Amount)
                        FROM CashTransaction CT
                        WHERE CT.DaySessionId = DS.DaySessionId
                          AND CT.TransactionType = 'CASH_IN'
                    ),
                    0
                )

                -

                ISNULL
                (
                    (
                        SELECT SUM(CT.Amount)
                        FROM CashTransaction CT
                        WHERE CT.DaySessionId = DS.DaySessionId
                          AND CT.TransactionType = 'CASH_OUT'
                    ),
                    0
                )

            ) AS ExpectedCash

FROM DaySession DS
WHERE DS.DaySessionId = @DaySessionId
AND DS.Status = 'Open';";

            var summary =
                await connection.QueryFirstOrDefaultAsync<DayClosingSummaryDto>(
                    sql,
                    new
                    {
                        DaySessionId = daySessionId
                    });

            if (summary == null)
            {
                throw new InvalidOperationException(
                    "No active business day session was found.");
            }

            return summary;
        }

        // ==========================================
        // CLOSE DAY
        // ==========================================

        public async Task CloseDayAsync(
            int daySessionId,
            decimal actualCash,
            int userId)
        {
            using var connection =
                _factory.CreateConnection();

            const string sql = @"

                DECLARE
                    @ExpectedCash
                        DECIMAL(18,2);

                DECLARE
                    @OpenDateTime
                        DATETIME;


                SELECT
                    @OpenDateTime =
                        OpenDateTime
                FROM DaySession
                WHERE DaySessionId =
                    @DaySessionId
                AND Status = 'Open';


                IF @OpenDateTime IS NULL
                BEGIN
                    THROW 50002,
                    'No active business day found.',
                    1;
                END;


                SELECT
                    @ExpectedCash =

                        OpeningCash

                        +

                        ISNULL(
                        (
                            SELECT
                                SUM(PaidAmount)
                            FROM SalesHeader
                            WHERE SaleDate >=
                                @OpenDateTime
                            AND PaymentMethod =
                                'cash'
                        ),0)

                        -

                        ISNULL(
                        (
                            SELECT
                                SUM(PaidAmount)
                            FROM PurchaseHeader
                            WHERE PurchaseDate >=
                                @OpenDateTime
                            AND PaymentMethod =
                                'cash'
                        ),0)

                FROM DaySession

                WHERE DaySessionId =
                    @DaySessionId;


                UPDATE DaySession

                SET
                    CloseDateTime =
                        GETDATE(),

                    ClosingCash =
                        @ActualCash,

                    ExpectedCash =
                        @ExpectedCash,

                    CashDifference =
                        @ActualCash -
                        @ExpectedCash,

                    Status =
                        'Closed',

                    ClosedBy =
                        @UserId

                WHERE DaySessionId =
                    @DaySessionId

                AND Status =
                    'Open';


                IF @@ROWCOUNT = 0
                BEGIN
                    THROW 50003,
                    'Business day could not be closed.',
                    1;
                END;";

            await connection.ExecuteAsync(
                sql,
                new
                {
                    DaySessionId =
                        daySessionId,

                    ActualCash =
                        actualCash,

                    UserId =
                        userId
                });
        }
    }
}