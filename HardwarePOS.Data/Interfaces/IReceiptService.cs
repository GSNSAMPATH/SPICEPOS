
using HardwarePOS.Models.DTOs.Printing;

namespace HardwarePOS.Business.Services
{
    public interface IReceiptService
    {
        ReceiptDataDto GetPurchaseReceipt(int purchaseId);

        ReceiptDataDto GetSalesReceipt(int saleId);

        void Print(ReceiptDataDto receipt);
    }
}
