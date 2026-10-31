namespace HardwarePOS.Models.DTOs
{
    public class DashboardStatsDto
    {
        // Today's Purchase
        public int TodayPurchaseCount { get; set; }
        public decimal TodayPurchaseAmount { get; set; }

        // Today's Sales
        public int TodaySalesCount { get; set; }
        public decimal TodaySalesAmount { get; set; }

        // Inventory
        public decimal InventoryValue { get; set; }
        public decimal TotalGrossWeight { get; set; }
        public decimal TotalNetWeight { get; set; }

        // Stock Status
        public int ProductsInStock { get; set; }
        public int OutOfStock { get; set; }

        public decimal CurrentCash { get; set; }
    }
}