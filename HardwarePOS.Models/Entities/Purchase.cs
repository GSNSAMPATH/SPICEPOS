public class PurchaseHeader
{
    public int PurchaseId { get; set; }

    public string PurchaseNo { get; set; } = "";

    public DateTime PurchaseDate { get; set; }

    public int SupplierId { get; set; }

    public decimal GrandTotal { get; set; }

    public decimal PaidAmount { get; set; }

    public decimal BalanceAmount { get; set; }

    public string PaymentMethod { get; set; } = "Cash";

    public string? Remarks { get; set; }

    public int CreatedBy { get; set; }

    public int DaySessionId { get; set; }

    public List<PurchaseDetail> Items { get; set; } = new();

}