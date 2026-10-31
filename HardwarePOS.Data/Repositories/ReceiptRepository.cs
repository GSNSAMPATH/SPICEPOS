
using Dapper;
using HardwarePOS.Data.Database;
using HardwarePOS.Data.Interfaces;
using HardwarePOS.Models.DTOs.Printing;
using HardwarePOS.Models.Entities;
using System;
using System.Linq;

namespace HardwarePOS.Data.Repositories
{
    public sealed class ReceiptRepository : IReceiptRepository
    {
        private readonly DbConnectionFactory _factory;

        public ReceiptRepository(DbConnectionFactory factory)
        {
            _factory = factory;
        }

        public ReceiptDataDto GetPurchaseReceipt(int purchaseId)
        {
            using var connection = _factory.CreateConnection();

            const string headerSql = @"
                SELECT
                    ph.PurchaseId,
                    ph.PurchaseNo,
                    ph.PurchaseDate,
                    ph.SupplierId,
                    ph.GrandTotal,
                    ph.PaymentMethod,
                    ph.PaidAmount,
                    ph.BalanceAmount
                FROM dbo.PurchaseHeader ph
                WHERE ph.PurchaseId = @PurchaseId;";

            const string itemsSql = @"
                SELECT
                    pd.ProductId,
                    p.ProductName,
                    c.CategoryName,
                    pd.PurchasePrice,
                    pd.GrossWeight,
                    pd.NetWeight,
                    pd.TotalPrice
                FROM dbo.PurchaseDetail pd
                INNER JOIN dbo.Product p
                    ON p.ProductId = pd.ProductId
                LEFT JOIN dbo.ProductCategory c
                    ON c.CategoryId = pd.CategoryId
                WHERE pd.PurchaseId = @PurchaseId
                ORDER BY pd.ProductId;";

            var header = connection.QueryFirstOrDefault<dynamic>(
                headerSql,
                new { PurchaseId = purchaseId });

            if (header == null)
            {
                throw new InvalidOperationException(
                    $"Purchase invoice {purchaseId} was not found.");
            }

            var items = connection.Query<dynamic>(
                itemsSql,
                new { PurchaseId = purchaseId });

            var receipt = new ReceiptDataDto
            {
                DocumentTitle = "PURCHASE INVOICE",
                InvoiceNumber = Convert.ToString(header.PurchaseNo) ?? "",
                InvoiceDate = Convert.ToDateTime(header.PurchaseDate),
                PartyLabel = "Supplier",
                PartyName = $"Supplier ID: {header.SupplierId}",
                PaymentMethod = Convert.ToString(header.PaymentMethod) ?? "",
                GrandTotal = Convert.ToDecimal(header.GrandTotal),
                PaidAmount = Convert.ToDecimal(header.PaidAmount),
                BalanceAmount = Convert.ToDecimal(header.BalanceAmount)
            };

            foreach (var item in items)
            {
                receipt.Items.Add(new ReceiptItemDto
                {
                    ItemName = $"{item.CategoryName}({item.ProductName})",
                    GrossWeight = Convert.ToDecimal(item.GrossWeight),
                    NetWeight = Convert.ToDecimal(item.NetWeight),
                    UnitPrice = Convert.ToDecimal(item.PurchasePrice),
                    LineTotal = Convert.ToDecimal(item.TotalPrice)
                });
            }

            return receipt;
        }

        public ReceiptDataDto GetSalesReceipt(int saleId)
        {
            using var connection = _factory.CreateConnection();

            const string headerSql = @"
                SELECT
                    sh.SalesId,
                    sh.InvoiceNumber,
                    sh.SaleDate,
                    sh.BuyerId,
                    sh.TotalAmount,
                    sh.PaymentMethod,
                    sh.PaidAmount,
                    sh.BalanceAmount,
                    sh.PaymentStatus,
                    sh.Remarks
                FROM dbo.SalesHeader sh
                WHERE sh.SalesId = @SaleId;";

            const string itemsSql = @"
                SELECT
                    sd.ProductId,
                    p.ProductName,
                    c.CategoryName,
                    sd.SellingPrice,
                    sd.GrossWeight,
                    sd.NetWeight,
                    sd.TotalPrice
                FROM dbo.SalesDetail sd
                INNER JOIN dbo.Product p
                    ON p.ProductId = sd.ProductId
                LEFT JOIN dbo.ProductCategory c
                    ON c.CategoryId = sd.CategoryId
                WHERE sd.SalesId = @SaleId
                ORDER BY sd.ProductId;";

            var header = connection.QueryFirstOrDefault<dynamic>(
                headerSql,
                new { SaleId = saleId });

            if (header == null)
            {
                throw new InvalidOperationException(
                    $"Sales invoice {saleId} was not found.");
            }

            var items = connection.Query<dynamic>(
                itemsSql,
                new { SaleId = saleId });

            var receipt = new ReceiptDataDto
            {
                DocumentTitle = "SALES INVOICE",
                InvoiceNumber = Convert.ToString(header.InvoiceNumber) ?? "",
                InvoiceDate = Convert.ToDateTime(header.SaleDate),
                PartyLabel = "Customer",
                PartyName = $"Customer ID: {header.BuyerId}",
                PaymentMethod = Convert.ToString(header.PaymentMethod) ?? "",
                Notes = Convert.ToString(header.Remarks) ?? "",
                GrandTotal = Convert.ToDecimal(header.TotalAmount),
                PaidAmount = Convert.ToDecimal(header.PaidAmount),
                BalanceAmount = Convert.ToDecimal(header.BalanceAmount)
            };

            foreach (var item in items)
            {
                receipt.Items.Add(new ReceiptItemDto
                {
                    ItemName = $"{item.CategoryName}({item.ProductName})",
                    //ItemName = $"Product ID: {item.ProductId}",
                    GrossWeight = Convert.ToDecimal(item.GrossWeight),
                    NetWeight = Convert.ToDecimal(item.NetWeight),
                    UnitPrice = Convert.ToDecimal(item.SellingPrice),
                    LineTotal = Convert.ToDecimal(item.TotalPrice)
                });
            }

            return receipt;
        }
    }
}
