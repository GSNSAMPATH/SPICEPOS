public class SalesHeader
{
    public int PurchaId { get; set; }

    public string InvoiceNumber { get; set; } = "";

    public DateTime SaleDate { get; set; }

    public int CustomerId { get; set; }

    public decimal GrandTotal { get; set; }

    public decimal PaidAmount { get; set; }

    public decimal BalanceAmount { get; set; }

    public string PaymentMethod { get; set; } = "Cash";

    public string? Remarks { get; set; }

    public int CreatedBy { get; set; }

    public int DaySessionId { get; set; }

    public List<SalesDetail> Items { get; set; } = new();

}