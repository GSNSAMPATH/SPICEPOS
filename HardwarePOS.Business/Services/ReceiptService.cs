
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.DTOs.Printing;
using System;

namespace HardwarePOS.Business.Services
{
    public class ReceiptService
    {
        private readonly ReceiptRepository _receiptRepository;
        private readonly IThermalReceiptPrinter _printer;

        public ReceiptService(
            ReceiptRepository receiptRepository,
            IThermalReceiptPrinter printer)
        {
            _receiptRepository = receiptRepository
                ?? throw new ArgumentNullException(nameof(receiptRepository));

            _printer = printer
                ?? throw new ArgumentNullException(nameof(printer));
        }

        public ReceiptDataDto GetPurchaseReceipt(int purchaseId)
        {
            if (purchaseId <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(purchaseId),
                    "Purchase ID must be greater than zero.");
            }

            return _receiptRepository.GetPurchaseReceipt(purchaseId);
        }

        public ReceiptDataDto GetSalesReceipt(int saleId)
        {
            if (saleId <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(saleId),
                    "Sale ID must be greater than zero.");
            }

            return _receiptRepository.GetSalesReceipt(saleId);
        }

        public void Print(ReceiptDataDto receipt)
        {
            if (receipt == null)
            {
                throw new ArgumentNullException(nameof(receipt));
            }

            _printer.Print(receipt);
        }
    }
}
