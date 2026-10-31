using HardwarePOS.Models.DTOs.Printing;

namespace HardwarePOS.Business.Services
{
    public interface IThermalReceiptPrinter
    {
        void Print(ReceiptDataDto receipt);
    }
}