namespace HardwarePOS.Models.DTOs
{
    public class DaySessionDto
    {
        public int DaySessionId { get; set; }

        public DateTime OpenDateTime { get; set; }

        public DateTime? CloseDateTime { get; set; }

        public decimal OpeningCash { get; set; }

        public decimal? ClosingCash { get; set; }

        public decimal? ExpectedCash { get; set; }

        public decimal? CashDifference { get; set; }

        public string Status { get; set; } = string.Empty;

        public int OpenedBy { get; set; }

        public int? ClosedBy { get; set; }
    }
}