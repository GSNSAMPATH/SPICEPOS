
using System;
using System.Collections.Generic;

namespace HardwarePOS.Models.DTOs.Printing
{
    public sealed class ReceiptDataDto
    {
        // Invoice information
        public string DocumentTitle { get; set; } = "INVOICE";
        public string InvoiceNumber { get; set; } = string.Empty;
        public DateTime InvoiceDate { get; set; } = DateTime.Now;

        // Business information
        public string BusinessName { get; set; } = "Spice POS";
        public string BusinessAddress { get; set; } = string.Empty;
        public string BusinessPhone { get; set; } = string.Empty;

        // Customer or supplier information
        public string PartyLabel { get; set; } = "Customer / Supplier";
        public string PartyName { get; set; } = string.Empty;

        // Payment information
        public string PaymentMethod { get; set; } = string.Empty;

        // Invoice items
        public List<ReceiptItemDto> Items { get; set; }
            = new List<ReceiptItemDto>();

        // Amounts
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal BalanceAmount { get; set; }

        // Additional information
        public string Notes { get; set; } = string.Empty;
        public string CurrencySymbol { get; set; } = "LKR ";
    }
}
