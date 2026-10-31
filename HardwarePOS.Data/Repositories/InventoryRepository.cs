using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.DTOs;

namespace HardwarePOS.Data.Repositories
{
    public class InventoryRepository
    {
        private readonly DbConnectionFactory _factory;

        public InventoryRepository(
            DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<decimal> GetAvailableStockAsync(int productId)
        {
            using var connection = _factory.CreateConnection();

            const string sql = @"
                                SELECT
                                    ISNULL(Balance, 0)
                                FROM Inventory
                                WHERE ProductId = @ProductId;";

            return await connection.ExecuteScalarAsync<decimal?>(sql,new{ProductId = productId})?? 0;
        }


        // =========================================================
        // CURRENT STOCK
        // =========================================================

        public async Task<IEnumerable<InventorySummaryDto>>
            GetCurrentStockAsync()
        {
            using var connection =
                _factory.CreateConnection();

            const string sql = @"
                SELECT
                    I.ProductId,
                    P.ProductName,
                    C.CategoryName,
                    U.UnitCode,

                    ISNULL(I.Balance, 0)
                        AS GrossWeight,

                    ISNULL(I.TareWeight, 0)
                        AS TareWeight,

                    ISNULL(I.WetWeight, 0)
                        AS WetWeight,

                    ISNULL(I.NetWeight, 0)
                        AS NetWeight,

                    ISNULL(I.AveragePrice, 0)
                        AS AveragePrice,

                    (
                        ISNULL(I.Balance, 0)
                        *
                        ISNULL(I.AveragePrice, 0)
                    ) AS TotalPrice

                FROM Inventory I

                INNER JOIN Product P
                    ON I.ProductId =
                       P.ProductId

                INNER JOIN ProductCategory C
                    ON P.CategoryId =
                       C.CategoryId

                INNER JOIN Unit U
                    ON P.UnitId =
                       U.UnitId

                ORDER BY
                    P.ProductName;";

            return await connection.QueryAsync<InventorySummaryDto>(sql);
        }


        // =========================================================
        // STOCK IN
        // =========================================================

        public async Task<IEnumerable<StockTransactionDto>>GetStockInAsync(DateTime fromDate, DateTime toDate)
        {
            using var connection = _factory.CreateConnection();

            var parameters = new
            {
                FromDate = fromDate.Date,
                ToDate = toDate.Date
            };

            const string sql = @"
                SELECT
                    ST.TransactionId,
                    ST.ProductId,
                    P.ProductName,
                    C.CategoryName,
                    U.UnitCode,
                    ST.TransactionType,
                    ST.ReferenceId,
                    ST.ReferenceNo,
                    ST.GrossWeight,
                    ST.Quantity,
                    ST.UnitPrice,
                    ST.TotalAmount,
                    ST.BalanceAfter,
                    ST.Remarks,
                    ST.TransactionDate

                FROM StockTransaction ST

                INNER JOIN Product P
                    ON ST.ProductId =
                       P.ProductId

                INNER JOIN ProductCategory C
                    ON ST.CategoryId =
                       C.CategoryId

                INNER JOIN Unit U
                    ON ST.UnitId =
                       U.UnitId

                WHERE ST.TransactionType IN
                (
                    'PURCHASE',
                    'RETURN',
                    'ADJUSTMENT+'
                )

                AND ST.TransactionType NOT IN
                (
                    'PURCHASE_VOID',
                    'SALE_VOID'
                )

                AND NOT EXISTS
                (
                    SELECT 1
                    FROM PurchaseHeader PH
                    WHERE PH.PurchaseId = ST.ReferenceId
                      AND ST.TransactionType = 'PURCHASE'
                      AND ISNULL(PH.Status, 'COMPLETED') = 'VOIDED'
                )

                AND ST.TransactionDate >= @FromDate
                AND ST.TransactionDate < DATEADD(DAY,1,@ToDate)

                ORDER BY
                    ST.TransactionDate DESC,
                    ST.TransactionId DESC;";

            return await connection.QueryAsync<StockTransactionDto>(sql, parameters);
        }


        // =========================================================
        // STOCK OUT
        // =========================================================

        public async Task<IEnumerable<StockTransactionDto>>GetStockOutAsync(DateTime fromDate, DateTime toDate)
        {
            using var connection = _factory.CreateConnection();

            var parameters = new
            {
                FromDate = fromDate.Date,
                ToDate = toDate.Date
            };

            const string sql = @"
                SELECT
                    ST.TransactionId,
                    ST.ProductId,
                    P.ProductName,
                    C.CategoryName,
                    U.UnitCode,
                    ST.TransactionType,
                    ST.ReferenceId,
                    ST.ReferenceNo,
                    ST.Quantity,
                    ST.GrossWeight,
                    ST.UnitPrice,
                    ST.TotalAmount,
                    ST.BalanceAfter,
                    ST.Remarks,
                    ST.TransactionDate

                FROM StockTransaction ST

                INNER JOIN Product P
                    ON ST.ProductId =
                       P.ProductId

                INNER JOIN ProductCategory C
                    ON ST.CategoryId =
                       C.CategoryId

                INNER JOIN Unit U
                    ON ST.UnitId =
                       U.UnitId

                WHERE ST.TransactionType IN
                (
                    'SALE',
                    'DAMAGE',
                    'ADJUSTMENT-'
                )

                AND ST.TransactionDate >= @FromDate
                AND ST.TransactionDate < DATEADD(DAY,1,@ToDate)

                ORDER BY
                    ST.TransactionDate DESC,
                    ST.TransactionId DESC;";

            return await connection.QueryAsync<StockTransactionDto>(sql, parameters);
        }


        // =========================================================
        // INVENTORY LEDGER
        // =========================================================

        public async Task<IEnumerable<StockTransactionDto>>GetLedgerAsync(DateTime fromDate, DateTime toDate)
        {
            using var connection = _factory.CreateConnection();

            var parameters = new
            {
                FromDate = fromDate.Date,
                ToDate = toDate.Date
            };

            const string sql = @"
                SELECT
                    ST.TransactionId,
                    ST.ProductId,
                    P.ProductName,
                    C.CategoryName,
                    U.UnitCode,
                    ST.TransactionType,
                    ST.ReferenceId,
                    ST.ReferenceNo,
                    ST.Quantity,
                    ST.GrossWeight,
                    ST.UnitPrice,
                    ST.TotalAmount,
                    ST.BalanceAfter,
                    ST.Remarks,
                    ST.TransactionDate

                FROM StockTransaction ST

                INNER JOIN Product P
                    ON ST.ProductId =
                       P.ProductId

                INNER JOIN ProductCategory C
                    ON ST.CategoryId =
                       C.CategoryId

                INNER JOIN Unit U
                    ON ST.UnitId =
                       U.UnitId

                WHERE 
                    ST.TransactionDate >= @FromDate
                    AND ST.TransactionDate < DATEADD(DAY,1,@ToDate)

                ORDER BY
                    ST.TransactionDate DESC,
                    ST.TransactionId DESC;";

            return await connection.QueryAsync<StockTransactionDto>(sql, parameters);
        }


        //// =========================================================
        //// INVENTORY DASHBOARD STATS
        //// =========================================================

        public async Task<InventoryStatsDto>GetInventoryStatsAsync()
        {
            using var connection =
                _factory.CreateConnection();

            const string sql = @"
                SELECT

                -- Products currently in stock
                (
                    SELECT COUNT(*)
                    FROM Inventory
                    WHERE ISNULL(GrossWeight, 0) > 0
                ) AS ProductsInStock,


                -- Current inventory value
                (
                    SELECT
                        ISNULL(
                            SUM(
                                ISNULL(GrossWeight, 0)
                                *
                                ISNULL(AveragePrice, 0)
                            ),
                            0
                        )
                    FROM Inventory
                ) AS InventoryValue,


                -- Low stock
                (
                    SELECT COUNT(*)

                    FROM Inventory I

                    INNER JOIN Product P
                        ON I.ProductId =
                           P.ProductId


                ) AS LowStockProducts,


                -- Today's stock movements
                (
                    SELECT COUNT(*)

                    FROM StockTransaction

                    WHERE TransactionDate >=
                        CAST(GETDATE() AS DATE)

                    AND TransactionDate <
                        DATEADD(
                            DAY,
                            1,
                            CAST(GETDATE() AS DATE)
                        )

                ) AS TodayMovements;";

            return await connection.QueryFirstAsync<InventoryStatsDto>(sql);
        }


        // =========================================================
        // GET CATEGORY NAMES
        // =========================================================

        public async Task<IEnumerable<string>>
            GetCategoriesAsync()
        {
            using var connection =
                _factory.CreateConnection();

            const string sql = @"
                SELECT
                    CategoryName

                FROM ProductCategory

                ORDER BY
                    CategoryName;";

            return await connection
                .QueryAsync<string>(
                    sql);
        }
    }
}