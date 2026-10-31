public class TransactionHistory
{
    public int Id { get; set; }

    public string TransactionType { get; set; } = "";

    public string InvoiceNo { get; set; } = "";

    public DateTime TransactionDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string PaymentMethod { get; set; } = "";

    public decimal PaidAmount { get; set; }

    public decimal BalanceAmount { get; set; }

    public string Status { get; set; } = "";

    public string CreatedBy { get; set; } = "";
}