namespace HardwarePOS.Models.DTOs
{
    public class StockTransactionDto
    {
        public int TransactionId { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; } =
            string.Empty;

        public string CategoryName { get; set; } =
            string.Empty;

        public string UnitCode { get; set; } =
            string.Empty;

        public string TransactionType { get; set; } =
            string.Empty;

        public int? ReferenceId { get; set; }

        public string ReferenceNo { get; set; } =
            string.Empty;

        public decimal Quantity { get; set; }

        public decimal GrossWeight { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal? BalanceAfter { get; set; }

        public string? Remarks { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}