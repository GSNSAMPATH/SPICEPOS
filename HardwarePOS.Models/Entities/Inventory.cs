namespace HardwarePOS.Models.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        public int? PurchaseDetailId { get; set; }

        public int ProductId { get; set; }

        public decimal StockIn { get; set; }

        public decimal StockOut { get; set; }

        public decimal Balance { get; set; }

        public decimal AveragePrice { get; set; }

        public decimal TareWeight { get; set; }

        public decimal WetWeight { get; set; }

        public decimal NetWeight { get; set; }

        public decimal GrossWeight { get; set; }

        public DateTime? LastUpdated { get; set; }

        public decimal LastPurchasePrice { get; set; }
    }
}