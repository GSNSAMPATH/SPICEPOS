
namespace HardwarePOS.Models.DTOs.Printing
{
    public sealed class ReceiptItemDto
    {
        public string ItemName { get; set; } = string.Empty;

        // Weight details
        public decimal GrossWeight { get; set; }
        public decimal NetWeight { get; set; }

        // Quantity and pricing
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }
}
