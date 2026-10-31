namespace HardwarePOS.Models.DTOs
{
    public class DayClosingSummaryDto
    {
        public int DaySessionId { get; set; }

        public decimal OpeningCash { get; set; }

        public decimal CashSales { get; set; }

        public decimal PurchasePayments { get; set; }

        public decimal Expenses { get; set; }

        public decimal CashIn { get; set; }

        public decimal CashOut { get; set; }

        public decimal ExpectedCash { get; set; }
    }
}