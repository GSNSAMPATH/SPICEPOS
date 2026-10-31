using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.DTOs.Printing;
using HardwarePOS.Models.Entities;
using HardwarePOS.Shared.Helpers;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;
using SpicePOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HardwarePOS.UI.Forms
{
    public partial class POSForm : BaseForm
    {
        private readonly PurchaseService _purchaseService;
        private readonly ProductService _productService;
        private readonly UnitService _unitService;
        private readonly ReceiptService _receiptService;
        private int daysetion;

        public POSForm()
        {
            InitializeComponent();
            var factory = ConnectionService.CreateFactory();
            var repository = new PurchaseRepository(factory);
            _purchaseService = new PurchaseService(repository);
            var Prepository = new ProductRepository(factory);
            _productService = new ProductService(Prepository);
            var unrepository = new UnitRepository(factory);
            _unitService = new UnitService(unrepository);

            // Receipt printing
            var receiptRepository = new ReceiptRepository(factory);
            IThermalReceiptPrinter printer = new ThermalReceiptPrinter();

            _receiptService = new ReceiptService(receiptRepository, printer);


            LoadPurchaseForm();
            GetDaySesstion0();
        }

        private async void LoadPurchaseForm()
        {
            LoadCurrentDate();
            txtInvoiceNo.Text = await _purchaseService.GetNextPurchaseNoAsync();

            LoadProductsAsync();

            LoadUnitsAsync();

        }

        private void LoadCurrentDate()
        {
            //Currentdatepic.Value = DateTime.Now;
        }

        private async Task LoadUnitsAsync()
        {
            var units = await _unitService.GetAllAsync();

            //cmbUnit.DataSource = units;
            //cmbUnit.DisplayMember = "UnitCode";
            //cmbUnit.ValueMember = "UnitId";
        }

        private async Task LoadProductsAsync()
        {
            var products = await _productService.GetCategoriesAsync();

            cmbCategory.DataSource = products;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1;
        }

        private void InitializeSummaryGrid()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;

            dataGridView2.RowHeadersVisible = false;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView2.ReadOnly = true;

            dataGridView2.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.Columns.Add("Field", "Field");
            dataGridView2.Columns.Add("Value", "Value");
        }

        private void LoadPurchaseSummary()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add("Customer", txtCustomerName.Text);
            dataGridView2.Rows.Add("Phone", txtTelephone.Text);
            dataGridView2.Rows.Add("", "");

            decimal grandTotal = 0;
            decimal totalNetWeight = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string product = row.Cells[0].Value?.ToString() ?? "";
                string category = row.Cells[2].Value?.ToString() ?? "";

                decimal qty = Convert.ToDecimal(row.Cells[10].Value);
                //decimal price = Convert.ToDecimal(row.Cells[8].Value);
                decimal total = Convert.ToDecimal(row.Cells[11].Value);
                string unit = row.Cells[5].Value?.ToString() ?? "";

                grandTotal += total;

                dataGridView2.Rows.Add(
                    "Product",
                    $"{product} - {category}");

                dataGridView2.Rows.Add(
                    "Qty × Price",
                    $"{qty:N2} {unit} = Rs.{total:N2}");
            }

            int rowIndex = dataGridView2.Rows.Add("Grand Total", $"Rs. {grandTotal:N2}");

            DataGridViewRow row0 = dataGridView2.Rows[rowIndex];

            row0.DefaultCellStyle.BackColor = Color.FromArgb(39, 174, 96);
            row0.DefaultCellStyle.ForeColor = Color.White;
            row0.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private async void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbCategory.SelectedValue is int CategoryId)
                {
                    await LoadCategoriesAsync(CategoryId);
                }
            }

        }

        private async Task LoadCategoriesAsync(int productId)
        {
            var categories = await _productService.GetCategoriesByProductAsync(productId);

            CmbProduct.DataSource = categories;
            CmbProduct.DisplayMember = "ProductName";
            CmbProduct.ValueMember = "ProductId";
            CmbProduct.SelectedIndex = 0;

        }

        //Currentdatepic

        private void button1_Click(object sender, EventArgs e)
        {
            decimal netWeight = GetNetWeight();
            decimal total = GetTotal();

            dataGridView1.Rows.Add(
                cmbCategory.Text,         // Product
                cmbCategory.SelectedValue,
                CmbProduct.Text,         // Grade
                CmbProduct.SelectedValue,
                txtPrice.Text,            // Price
                "KG",             // Unit
                1,
                txtGrossWeight.Text,      // Gross
                txtTareWeight.Text,       // Tare
                txtWetWeight.Text,        // Wet
                netWeight.ToString("N2"), // Net
                total.ToString("N2")      // Total
            );

            ClearProductArea();

            CalculateGrandTotal();
            LoadPurchaseSummary();
        }

        private decimal GetNetWeight()
        {
            decimal gross = decimal.TryParse(txtGrossWeight.Text, out var g) ? g : 0;
            decimal tare = decimal.TryParse(txtTareWeight.Text, out var t) ? t : 0;
            decimal wet = decimal.TryParse(txtWetWeight.Text, out var w) ? w : 0;

            return gross - tare - wet;
        }

        private decimal GetTotal()
        {
            decimal price = decimal.TryParse(txtPrice.Text, out var p) ? p : 0;

            return GetNetWeight() * price;
        }
        private void ClearProductArea()
        {
            CmbProduct.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            //cmbUnit.SelectedIndex = -1;

            txtPrice.Value = 0;
            txtGrossWeight.Value = 0;
            txtTareWeight.Value = 0;
            txtWetWeight.Value = 0;

            txtPrice.Focus();
        }

        private decimal CalculateGrandTotal()
        {
            decimal grandTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                grandTotal += Convert.ToDecimal(row.Cells[11].Value);
            }

            return grandTotal;
        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {
            LoadPurchaseSummary();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            LoadPurchaseSummary();
        }

        private async void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                btnBuy.Enabled = false;

                PurchaseHeader purchase = BuildPurchase();

                int purchaseId = await _purchaseService.SavePurchaseAsync(purchase);

                MessageBox.Show($"Purchase Saved Successfully.\nPurchase Id : {purchaseId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    ReceiptDataDto receipt =
                        _receiptService.GetPurchaseReceipt(purchaseId);

                    receipt.DocumentTitle = "PURCHASE INVOICE";

                    _receiptService.Print(receipt);
                }
                catch (Exception printEx)
                {
                    MessageBox.Show(
                        "Purchase saved successfully, but printing failed:\n" +
                        printEx.Message,
                        "Printing Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                await ClearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnBuy.Enabled = true;
            }
        }

        public async void GetDaySesstion0()
        {
            daysetion = await _purchaseService.GetDaySesstion();

        }


        private PurchaseHeader BuildPurchase()
        {
            PurchaseHeader purchase = new();

            purchase.PurchaseNo = txtInvoiceNo.Text;

            purchase.PurchaseDate = DateTime.Now;

            //purchase.SupplierId = Convert.ToInt32(cmbSupplier.SelectedValue);

            purchase.SupplierId = 1;

            purchase.GrandTotal = CalculateGrandTotal();

            purchase.PaidAmount = CalculateGrandTotal();

            purchase.BalanceAmount = 0;

            purchase.DaySessionId = daysetion;

            //purchase.Remarks = txtRemarks.Text;

            purchase.CreatedBy = UserSession.CurrentUser!.StaffId;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;

                purchase.Items.Add(new PurchaseDetail
                {
                    ProductId = Convert.ToInt32(row.Cells["Column13"].Value),

                    CategoryId = Convert.ToInt32(row.Cells["Column12"].Value),

                    UnitId = Convert.ToInt32(row.Cells["Column14"].Value),

                    PurchasePrice = Convert.ToDecimal(row.Cells["Column3"].Value),

                    GrossWeight = Convert.ToDecimal(row.Cells["Column4"].Value),

                    TareWeight = Convert.ToDecimal(row.Cells["Column5"].Value),

                    WetWeight = Convert.ToDecimal(row.Cells["Column6"].Value),

                    NetWeight = Convert.ToDecimal(row.Cells["Column7"].Value),

                    TotalPrice = Convert.ToDecimal(row.Cells["Column8"].Value)
                });
            }

            return purchase;
        }

        private async Task ClearForm()
        {
            // Header
            txtCustomerName.Clear();
            txtTelephone.Clear();
            //txtRemarks.Clear();

            // Generate next invoice number
            txtInvoiceNo.Text = await _purchaseService.GetNextPurchaseNoAsync();

            // Clear grids
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            // Clear purchase items list
            //_purchaseItems.Clear();

            // Clear product area
            ClearProductArea();

            txtCustomerName.Focus();
        }

        private void txtWetWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGrossWeight_Click(object sender, EventArgs e)
        {
            txtGrossWeight.Select(0, txtGrossWeight.Text.Length);
        }

        private void txtTareWeight_Click(object sender, EventArgs e)
        {
            txtTareWeight.Select(0, txtTareWeight.Text.Length);
        }

        private void txtWetWeight_Click(Object sender, EventArgs e)
        {
            txtWetWeight.Select(0, txtWetWeight.Text.Length);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }

}
