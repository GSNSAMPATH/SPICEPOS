using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Models.DTOs;
using Microsoft.Data.SqlClient;
using System.Data;

namespace HardwarePOS.Data.Repositories
{
    public class DashboardRepository
    {
        private readonly DbConnectionFactory _factory;

        public DashboardRepository(
            DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public async Task<DashboardStatsDto>
            GetDashboardStatsAsync()
        {
            using var connection =
                _factory.CreateConnection();

            string sql = @"
                        -- Current Open Day Session
DECLARE @DaySessionId INT;
DECLARE @DayStart DATETIME;

SELECT TOP 1
    @DaySessionId = DaySessionId,
    @DayStart = OpenDateTime
FROM DaySession
WHERE Status = 'OPEN'
ORDER BY DaySessionId DESC;


SELECT

    ---------------------------------------------------
    -- Today's Purchase
    ---------------------------------------------------

    (
        SELECT COUNT(*)
        FROM PurchaseHeader
        WHERE PurchaseDate >= @DayStart
          AND PurchaseDate <= GETDATE()
          AND ISNULL(Status, 'COMPLETED') <> 'VOIDED'
    ) AS TodayPurchaseCount,

    (
        SELECT ISNULL(SUM(GrandTotal), 0)
        FROM PurchaseHeader
        WHERE PurchaseDate >= @DayStart
          AND PurchaseDate <= GETDATE()
          AND ISNULL(Status, 'COMPLETED') <> 'VOIDED'
    ) AS TodayPurchaseAmount,


    ---------------------------------------------------
    -- Today's Sales
    ---------------------------------------------------

    (
        SELECT COUNT(*)
        FROM SalesHeader
        WHERE SaleDate >= @DayStart
          AND SaleDate <= GETDATE()
          AND ISNULL(Status, 'COMPLETED') <> 'VOIDED'
    ) AS TodaySalesCount,

    (
        SELECT ISNULL(SUM(TotalAmount), 0)
        FROM SalesHeader
        WHERE SaleDate >= @DayStart
          AND SaleDate <= GETDATE()
          AND ISNULL(Status, 'COMPLETED') <> 'VOIDED'
    ) AS TodaySalesAmount,


    ---------------------------------------------------
    -- Inventory Value
    ---------------------------------------------------

    (
        SELECT ISNULL(
            SUM(InventoryValue), 0
        )
        FROM Inventory
        WHERE NetWeight > 0
    ) AS InventoryValue,


    ---------------------------------------------------
    -- Total Stock
    ---------------------------------------------------

    (
        SELECT ISNULL(
            SUM(StockIn - StockOut), 0
        )
        FROM Inventory
    ) AS TotalGrossWeight,


    (
        SELECT ISNULL(
            SUM(NetWeight), 0
        )
        FROM Inventory
    ) AS TotalNetWeight,


    ---------------------------------------------------
    -- Products In Stock
    ---------------------------------------------------

    (
        SELECT COUNT(*)
        FROM Inventory
        WHERE (StockIn - StockOut) > 0
    ) AS ProductsInStock,


    ---------------------------------------------------
    -- Out Of Stock
    ---------------------------------------------------

    (
        SELECT COUNT(*)
        FROM Inventory
        WHERE (StockIn - StockOut) <= 0
    ) AS OutOfStock,


    ---------------------------------------------------
    -- Current Cash
    ---------------------------------------------------

    (
        SELECT
            ISNULL(ds.OpeningCash, 0)

            +

            ISNULL(
                (
                    SELECT SUM(ct.Amount)
                    FROM CashTransaction ct
                    WHERE ct.DaySessionId = ds.DaySessionId
                      AND ct.TransactionType = 'CASH_IN'
                ), 0
            )

            -

            ISNULL(
                (
                    SELECT SUM(ct.Amount)
                    FROM CashTransaction ct
                    WHERE ct.DaySessionId = ds.DaySessionId
                      AND ct.TransactionType = 'CASH_OUT'
                ), 0
            )

        FROM DaySession ds
        WHERE ds.DaySessionId = @DaySessionId

    ) AS CurrentCash;";

            return await connection.QueryFirstAsync<DashboardStatsDto>(sql);
        }

        public async Task<IEnumerable<InventorySummaryDto>> GetProductSummaryAsync()
        {
            using var connection = _factory.CreateConnection();

            const string sql = @"
                                SELECT
                                inv.ProductId,
                                cat.CategoryName,
                                pr.ProductName,
                                u.UnitCode,
                                inv.AveragePrice,
                                inv.StockIn - inv.StockOut AS GrossWeight,
                                inv.TareWeight,
                                inv.WetWeight,
                                inv.NetWeight,

    
                                inv.InventoryValue AS TotalPrice

                            FROM Inventory inv
                            INNER JOIN Product pr
                                ON inv.ProductId = pr.ProductId
                            INNER JOIN ProductCategory cat
                                ON pr.CategoryId = cat.CategoryId
                            INNER JOIN Unit u
                                ON pr.UnitId = u.UnitId;";

            return await connection.QueryAsync<InventorySummaryDto>(sql);
        }

    }

}