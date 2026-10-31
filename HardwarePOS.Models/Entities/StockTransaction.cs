namespace HardwarePOS.Models.Entities
{
    public class StockTransaction
    {
        public int TransactionId { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public int UnitId { get; set; }

        public string TransactionType { get; set; } =
            string.Empty;

        public int? ReferenceId { get; set; }

        public string? ReferenceNo { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal? BalanceAfter { get; set; }

        public string? Remarks { get; set; }

        public DateTime TransactionDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}