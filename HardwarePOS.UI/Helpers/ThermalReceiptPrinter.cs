using HardwarePOS.Business.Services;
using HardwarePOS.Models.DTOs.Printing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace SpicePOS
{
    public sealed class ThermalReceiptPrinter : IThermalReceiptPrinter
    {
        private const int PaperWidth = 576;
        private const int Margin = 12;

        private static readonly string[] PreferredFonts =
        {
            "Noto Sans Sinhala",
            "Iskoola Pota",
            "Nirmala UI"
        };

        public void Print(ReceiptDataDto receipt)
        {
            if (!TryPrint(receipt, out string error))
            {
                throw new InvalidOperationException(error);
            }
        }

        public static string GetDefaultPrinterName()
        {
            var settings = new PrinterSettings();

            if (!settings.IsValid ||
                string.IsNullOrWhiteSpace(settings.PrinterName))
            {
                throw new InvalidOperationException(
                    "No valid Windows default printer is configured.");
            }

            return settings.PrinterName;
        }

        // new
        private static Bitmap TrimTopWhitespace(Bitmap bitmap)
        {
            int firstContentRow = 0;

            for (int y = 0; y < bitmap.Height; y++)
            {
                bool hasContent = false;

                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color pixel = bitmap.GetPixel(x, y);

                    int luminance =
                        (pixel.R * 299 +
                         pixel.G * 587 +
                         pixel.B * 114) / 1000;

                    if (luminance < 180)
                    {
                        hasContent = true;
                        break;
                    }
                }

                if (hasContent)
                {
                    firstContentRow = y;
                    break;
                }
            }

            if (firstContentRow == 0)
                return (Bitmap)bitmap.Clone();

            int newHeight = bitmap.Height - firstContentRow;

            return bitmap.Clone(
                new Rectangle(
                    0,
                    firstContentRow,
                    bitmap.Width,
                    newHeight),
                bitmap.PixelFormat);
        }

        // new

        public static bool TryPrint(
            ReceiptDataDto receipt,
            out string error)
        {
            error = string.Empty;

            try
            {
                if (receipt == null)
                    throw new ArgumentNullException(nameof(receipt));

                if (receipt.Items == null || receipt.Items.Count == 0)
                {
                    throw new InvalidOperationException(
                        "Cannot print an invoice without items.");
                }

                string printerName = GetDefaultPrinterName();

                //using Bitmap bitmap = RenderReceipt(receipt);
                //byte[] imageBytes = CreateEscPosImage(bitmap);

                //using Bitmap bitmap = RenderReceipt(receipt);
                //using Bitmap trimmedBitmap = TrimTopWhitespace(bitmap);

                //byte[] imageBytes = CreateEscPosImage(trimmedBitmap);

                using Bitmap bitmap = RenderReceipt(receipt);

                // Save the exact bitmap sent to the printer
                bitmap.Save(
                    Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "receipt-debug.png"
                    ),
                    System.Drawing.Imaging.ImageFormat.Png
                );

                byte[] imageBytes = CreateEscPosImage(bitmap);

                // New

                var output = new List<byte>
                {
                    0x1B, 0x40 // ESC @ - Initialize printer
                };

                output.AddRange(imageBytes);

                // Feed paper.
                output.AddRange(new byte[]
                {
                    //0x1B, 0x64, 0x04
                    0x1B, 0x64, 0x01
                });

                // Cut paper, if supported by the printer.
                output.AddRange(new byte[]
                {
                    0x1D, 0x56, 0x42, 0x00
                });

                if (!RawPrinterHelper.SendBytesToPrinter(
                    printerName,
                    output.ToArray(),
                    out int winError))
                {
                    throw new InvalidOperationException(
                        $"Could not send receipt to '{printerName}'. " +
                        $"Windows error: {winError}. " +
                        "Check the printer connection and queue.");
                }

                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        private static Bitmap RenderReceipt(ReceiptDataDto receipt)
        {
            int contentWidth = PaperWidth - (Margin * 2);

            string fontName = PreferredFonts.FirstOrDefault(name =>
                FontFamily.Families.Any(f =>
                    string.Equals(
                        f.Name,
                        name,
                        StringComparison.OrdinalIgnoreCase)))
                ?? FontFamily.GenericSansSerif.Name;

            using var regular = new Font(
                fontName, 28f, FontStyle.Regular, GraphicsUnit.Pixel);

            using var bold = new Font(
                fontName, 32f, FontStyle.Bold, GraphicsUnit.Pixel);

            using var titleFont = new Font(
                fontName, 40f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Same font size as the other receipt text.
            // Long cell values wrap onto the next line.
            using var tableFont = new Font(
                fontName, 28f, FontStyle.Regular, GraphicsUnit.Pixel);

            using var tableBold = new Font(
                fontName, 32f, FontStyle.Bold, GraphicsUnit.Pixel);

            // ITEM | NET WT | UNIT PRICE | AMOUNT
            float[] columnWidths =
            {
                150f, 100f, 140f, 150f
            };

            using var measureBitmap = new Bitmap(1, 1);
            using var mg = Graphics.FromImage(measureBitmap);

            mg.TextRenderingHint =
                System.Drawing.Text.TextRenderingHint.AntiAlias;

            int height = 4;

            void AddTextHeight(string? text, Font font)
            {
                var measured = mg.MeasureString(
                    string.IsNullOrEmpty(text) ? " " : text,
                    font,
                    contentWidth);

                height += Math.Max(
                    (int)Math.Ceiling(measured.Height) + 4,
                    16);
            }

            void AddTableRowHeight(string[] cells, Font font)
            {
                float maxCellHeight = 0;

                for (int i = 0; i < cells.Length; i++)
                {
                    var measured = mg.MeasureString(
                        string.IsNullOrEmpty(cells[i]) ? " " : cells[i],
                        font,
                        (int)columnWidths[i]);

                    maxCellHeight = Math.Max(
                        maxCellHeight,
                        measured.Height);
                }

                height += (int)Math.Ceiling(maxCellHeight) + 8;
            }

            //string money(decimal amount) => $"{receipt.CurrencySymbol}{amount:N2}";
            string money(decimal amount) => $"{amount:N2}";

            string businessName =  "J K පොඩියුස්";

            string BusinessAddress = "J K පොඩියුස්, පස්ගොඩ";

            string BusinessPhone = "076 9952497";

            // ------------------------------------
            // Calculate receipt height
            // ------------------------------------

            AddTextHeight(businessName, titleFont);

            //if (!string.IsNullOrWhiteSpace(receipt.BusinessAddress))
            AddTextHeight(BusinessAddress, regular);

            //if (!string.IsNullOrWhiteSpace(receipt.BusinessPhone))
            AddTextHeight(BusinessPhone, regular);

            AddTextHeight(receipt.DocumentTitle, bold);

            AddTextHeight("Invoice: " + receipt.InvoiceNumber,regular);

            AddTextHeight("Date: " + receipt.InvoiceDate.ToString("yyyy-MM-dd HH:mm"),regular);


            if (!string.IsNullOrWhiteSpace(receipt.PartyLabel))
            {
                AddTextHeight(
                    $"{receipt.PartyLabel}: {receipt.PartyName}",
                    regular);
            }
            else if (!string.IsNullOrWhiteSpace(receipt.PartyName))
            {
                //AddTextHeight(
                //    "Customer / Supplier: " + receipt.PartyName,
                //    regular);
            }

            AddTextHeight(new string('-', 32), regular);

            // Table header.
            AddTableRowHeight(
                new[]
                {
                    "ITEM",
                    "NET WT",
                    "UNIT PRICE",
                    "AMOUNT"
                },
                tableBold);

            // Table item rows.
            foreach (var item in receipt.Items)
            {
                AddTableRowHeight(
                    new[]
                    {
                        item.ItemName ?? string.Empty,
                        $"{item.NetWeight:N3} kg",
                        money(item.UnitPrice),
                        money(item.LineTotal)
                    },
                    tableFont);
            }

            AddTextHeight(new string('-', 32), regular);

            // Totals and payment information.
            //AddTextHeight(
            //    $"Subtotal: {money(receipt.Subtotal)}",
            //    regular);

            //AddTextHeight(
            //    $"Discount: {money(receipt.Discount)}",
            //    regular);

            AddTextHeight(
                $"TOTAL: {money(receipt.GrandTotal)}",
                bold);

            //AddTextHeight(
            //    $"PAID: {money(receipt.PaidAmount)}",
            //    regular);

            //AddTextHeight(
            //    $"BALANCE: {money(receipt.BalanceAmount)}",
            //    bold);

            //if (!string.IsNullOrWhiteSpace(receipt.PaymentMethod))
            //{
            //    AddTextHeight(
            //        "Payment: " + receipt.PaymentMethod,
            //        regular);
            //}

            if (!string.IsNullOrWhiteSpace(receipt.Notes))
            {
                AddTextHeight(
                    "Notes: " + receipt.Notes,
                    regular);
            }

            AddTextHeight("Thank you!", bold);

            // Small bottom padding.
            height += 5;

            var bitmap = new Bitmap(
                PaperWidth,
                height,
                PixelFormat.Format24bppRgb);

            using (var g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                g.SmoothingMode = SmoothingMode.HighQuality;

                g.TextRenderingHint =
                    System.Drawing.Text.TextRenderingHint.AntiAlias;

                //int y = 8;
                int y = 0;

                void DrawText(
                    string? text,
                    Font font,
                    bool center = false)
                {
                    text ??= string.Empty;

                    var rect = new RectangleF(
                        Margin,
                        y,
                        contentWidth,
                        Math.Max(1, height - y));

                    using var format = new StringFormat
                    {
                        Alignment = center
                            ? StringAlignment.Center
                            : StringAlignment.Near,

                        LineAlignment = StringAlignment.Near,
                        Trimming = StringTrimming.Word
                    };

                    var measured = g.MeasureString(
                        string.IsNullOrEmpty(text) ? " " : text,
                        font,
                        contentWidth,
                        format);

                    g.DrawString(
                        string.IsNullOrEmpty(text) ? " " : text,
                        font,
                        Brushes.Black,
                        rect,
                        format);

                    y += Math.Max(
                        (int)Math.Ceiling(measured.Height) + 4,
                        16);
                }

                void DrawRule()
                {
                    DrawText(
                        new string('-', 56),
                        regular,
                        true);
                }

                void DrawTableRow(string[] cells, Font font)
                {
                    float maxCellHeight = 0;

                    // Measure each cell using its column width.
                    // This calculates the height needed for wrapped text.
                    for (int i = 0; i < cells.Length; i++)
                    {
                        var measured = g.MeasureString(
                            string.IsNullOrEmpty(cells[i])
                                ? " "
                                : cells[i],
                            font,
                            (int)columnWidths[i]);

                        maxCellHeight = Math.Max(
                            maxCellHeight,
                            measured.Height);
                    }

                    float rowHeight =
                        (float)Math.Ceiling(maxCellHeight) + 8;

                    float x = Margin;

                    for (int i = 0; i < cells.Length; i++)
                    {
                        using var format = new StringFormat
                        {
                            Alignment = i == 0
                                ? StringAlignment.Near
                                : StringAlignment.Far,

                            LineAlignment = StringAlignment.Near,
                            Trimming = StringTrimming.Word
                        };

                        var rect = new RectangleF(
                            x,
                            y,
                            columnWidths[i] - 3,
                            rowHeight);

                        g.DrawString(
                            string.IsNullOrEmpty(cells[i])
                                ? " "
                                : cells[i],
                            font,
                            Brushes.Black,
                            rect,
                            format);

                        x += columnWidths[i];
                    }

                    y += (int)rowHeight;

                    using var pen = new Pen(Color.Black, 1);

                    g.DrawLine(
                        pen,
                        Margin,
                        y - 2,
                        Margin + columnWidths.Sum(),
                        y - 2);
                }

                // ------------------------------------
                // Draw business header
                // ------------------------------------

                DrawText(businessName, titleFont, true);

                //if (!string.IsNullOrWhiteSpace(receipt.BusinessAddress))
                    DrawText(BusinessAddress, regular, true);

                //if (!string.IsNullOrWhiteSpace(receipt.BusinessPhone))
                    DrawText(BusinessPhone, bold, true);

                DrawText(receipt.DocumentTitle, bold, true);

                DrawText(
                    "Invoice: " + receipt.InvoiceNumber,
                    regular);

                DrawText(
                    receipt.InvoiceDate.ToString("yyyy-MM-dd HH:mm"),
                    regular);

                //if (!string.IsNullOrWhiteSpace(receipt.PartyLabel))
                //{
                //    DrawText(
                //        $"{receipt.PartyLabel}: {receipt.PartyName}",
                //        regular);
                //}
                //else if (!string.IsNullOrWhiteSpace(receipt.PartyName))
                //{
                //    DrawText(
                //        "Customer / Supplier: " + receipt.PartyName,
                //        regular);
                //}

                DrawRule();

                // ------------------------------------
                // Four-column item table
                // ------------------------------------

                DrawTableRow(
                    new[]
                    {
                        "ITEM",
                        "NET WT",
                        "UNIT PRICE",
                        "AMOUNT"
                    },
                    tableBold);

                foreach (var item in receipt.Items)
                {
                    DrawTableRow(
                        new[]
                        {
                            item.ItemName ?? string.Empty,
                            $"{item.NetWeight:N2} kg",
                            money(item.UnitPrice),
                            money(item.LineTotal)
                        },
                        tableFont);
                }

                DrawRule();

                // ------------------------------------
                // Totals and payment information
                // ------------------------------------

                //DrawText(
                //    $"Subtotal: {money(receipt.Subtotal)}",
                //    regular);

                //DrawText(
                //    $"Discount: {money(receipt.Discount)}",
                //    regular);

                DrawText(
                    $"TOTAL: {money(receipt.GrandTotal)}",
                    bold);

                //DrawText(
                //    $"PAID: {money(receipt.PaidAmount)}",
                //    regular);

                //DrawText(
                //    $"BALANCE: {money(receipt.BalanceAmount)}",
                //    bold);

                //if (!string.IsNullOrWhiteSpace(receipt.PaymentMethod))
                //{
                //    DrawText(
                //        "Payment: " + receipt.PaymentMethod,
                //        regular);
                //}

                if (!string.IsNullOrWhiteSpace(receipt.Notes))
                {
                    DrawText(
                        "Notes: " + receipt.Notes,
                        regular);
                }

                DrawText("Thank you!", bold, true);
            }

            return bitmap;
        }

        private static byte[] CreateEscPosImage(Bitmap bitmap)
        {
            using var ms = new MemoryStream();

            int widthBytes = (bitmap.Width + 7) / 8;

            // Send image in chunks of up to 256 rows.
            for (int startY = 0;
                 startY < bitmap.Height;
                 startY += 256)
            {
                int rows = Math.Min(
                    256,
                    bitmap.Height - startY);

                ms.Write(new byte[]
                {
                    0x1D, 0x76, 0x30, 0x00,
                    (byte)(widthBytes & 0xFF),
                    (byte)((widthBytes >> 8) & 0xFF),
                    (byte)(rows & 0xFF),
                    (byte)((rows >> 8) & 0xFF)
                });

                for (int y = startY; y < startY + rows; y++)
                {
                    for (int xb = 0; xb < widthBytes; xb++)
                    {
                        byte value = 0;

                        for (int bit = 0; bit < 8; bit++)
                        {
                            int x = xb * 8 + bit;

                            if (x >= bitmap.Width)
                                continue;

                            Color c = bitmap.GetPixel(x, y);

                            int luminance =
                                (c.R * 299 +
                                 c.G * 587 +
                                 c.B * 114) / 1000;

                            if (luminance < 180)
                            {
                                value |= (byte)(0x80 >> bit);
                            }
                        }

                        ms.WriteByte(value);
                    }
                }
            }

            return ms.ToArray();
        }
    }

    internal static class RawPrinterHelper
    {
        [StructLayout(
            LayoutKind.Sequential,
            CharSet = CharSet.Unicode)]
        private class DOCINFO
        {
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pDocName = "Spice POS Receipt";

            [MarshalAs(UnmanagedType.LPWStr)]
            public string? pOutputFile = null;

            [MarshalAs(UnmanagedType.LPWStr)]
            public string pDataType = "RAW";
        }

        [DllImport(
            "winspool.drv",
            EntryPoint = "OpenPrinterW",
            SetLastError = true,
            CharSet = CharSet.Unicode)]
        private static extern bool OpenPrinter(
            string printerName,
            out IntPtr printerHandle,
            IntPtr defaults);

        [DllImport(
            "winspool.drv",
            EntryPoint = "ClosePrinter",
            SetLastError = true)]
        private static extern bool ClosePrinter(
            IntPtr printerHandle);

        [DllImport(
            "winspool.drv",
            EntryPoint = "StartDocPrinterW",
            SetLastError = true,
            CharSet = CharSet.Unicode)]
        private static extern int StartDocPrinter(
            IntPtr printerHandle,
            int level,
            [In] DOCINFO documentInfo);

        [DllImport(
            "winspool.drv",
            SetLastError = true)]
        private static extern bool EndDocPrinter(
            IntPtr printerHandle);

        [DllImport(
            "winspool.drv",
            SetLastError = true)]
        private static extern bool StartPagePrinter(
            IntPtr printerHandle);

        [DllImport(
            "winspool.drv",
            SetLastError = true)]
        private static extern bool EndPagePrinter(
            IntPtr printerHandle);

        [DllImport(
            "winspool.drv",
            SetLastError = true)]
        private static extern bool WritePrinter(
            IntPtr printerHandle,
            IntPtr bytes,
            int count,
            out int written);

        public static bool SendBytesToPrinter(
            string printerName,
            byte[] bytes,
            out int errorCode)
        {
            errorCode = 0;

            IntPtr printer = IntPtr.Zero;
            IntPtr unmanagedBytes = IntPtr.Zero;

            bool documentStarted = false;
            bool pageStarted = false;

            try
            {
                if (!OpenPrinter(
                    printerName,
                    out printer,
                    IntPtr.Zero))
                {
                    errorCode = Marshal.GetLastWin32Error();
                    return false;
                }

                var doc = new DOCINFO();

                if (StartDocPrinter(printer, 1, doc) == 0)
                {
                    errorCode = Marshal.GetLastWin32Error();
                    return false;
                }

                documentStarted = true;

                if (!StartPagePrinter(printer))
                {
                    errorCode = Marshal.GetLastWin32Error();
                    return false;
                }

                pageStarted = true;

                unmanagedBytes = Marshal.AllocHGlobal(bytes.Length);

                Marshal.Copy(
                    bytes,
                    0,
                    unmanagedBytes,
                    bytes.Length);

                bool ok = WritePrinter(
                    printer,
                    unmanagedBytes,
                    bytes.Length,
                    out int written);

                if (!ok || written != bytes.Length)
                {
                    errorCode = Marshal.GetLastWin32Error();
                    return false;
                }

                return true;
            }
            finally
            {
                if (unmanagedBytes != IntPtr.Zero)
                    Marshal.FreeHGlobal(unmanagedBytes);

                if (pageStarted)
                    EndPagePrinter(printer);

                if (documentStarted)
                    EndDocPrinter(printer);

                if (printer != IntPtr.Zero)
                    ClosePrinter(printer);
            }
        }
    }
}