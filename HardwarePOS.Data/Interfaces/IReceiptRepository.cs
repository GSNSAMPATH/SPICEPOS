
using HardwarePOS.Models.DTOs.Printing;

namespace HardwarePOS.Data.Interfaces
{
    public interface IReceiptRepository
    {
        ReceiptDataDto GetPurchaseReceipt(int purchaseId);

        ReceiptDataDto GetSalesReceipt(int saleId);
    }
}
