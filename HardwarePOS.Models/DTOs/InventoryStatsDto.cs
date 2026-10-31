namespace HardwarePOS.Models.DTOs
{
    public class InventoryStatsDto
    {
        public int ProductsInStock { get; set; }

        public decimal InventoryValue { get; set; }

        public int LowStockProducts { get; set; }

        public int TodayMovements { get; set; }
    }
}