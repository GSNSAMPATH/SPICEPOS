namespace HardwarePOS.Models.Entities
{
    public class CashTransaction
    {
        public int CashTransactionId { get; set; }

        public DateTime TransactionDate { get; set; }

        public string TransactionType { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public string? ReferenceNo { get; set; }

        public string? Remarks { get; set; }

        public int CreatedBy { get; set; }

        public string CreatedByName { get; set; } = "";

        public int DaySessionId { get; set; }

        public DateTime DaySessionDate { get; set; }
    }
}