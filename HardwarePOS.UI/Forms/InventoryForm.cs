using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.DTOs;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HardwarePOS.UI.Forms
{
    public partial class InventoryForm : BaseForm

    {

        private readonly InventoryService _inventoryService;

        private List<InventorySummaryDto> _currentStock = new List<InventorySummaryDto>();

        private List<StockTransactionDto> _stockIn = new List<StockTransactionDto>();

        private List<StockTransactionDto> _stockOut = new List<StockTransactionDto>();

        private List<StockTransactionDto> _ledger = new List<StockTransactionDto>();


        public InventoryForm()
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();
            var repository = new InventoryRepository(factory);
            _inventoryService = new InventoryService(repository);
            InventoryForm_Load();


        }


        private async void InventoryForm_Load()
        {
            try
            {
                ConfigureGrids();

                await LoadDashboardCardsAsync();

                await LoadCurrentStockAsync();

                await LoadStockInAsync();

                await LoadStockOutAsync();

                await LoadLedgerAsync();

                await LoadCategoriesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inventory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigureGrids()
        {
            ConfigureGrid(dgvProducts);

            ConfigureGrid(dataGridView1);

            ConfigureGrid(dataGridView2);

            ConfigureGrid(dataGridView3);
        }


        private void ConfigureGrid(DataGridView grid)
        {
            grid.AutoGenerateColumns = false;

            grid.AllowUserToAddRows = false;

            grid.AllowUserToDeleteRows = false;

            grid.AllowUserToResizeRows = false;

            grid.ReadOnly = true;

            grid.MultiSelect = false;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid.RowHeadersVisible = false;
        }


        private async Task LoadDashboardCardsAsync()
        {
            var stats = await _inventoryService.GetInventoryStatsAsync();

            //label9.Text = stats.ProductsInStock.ToString();

            //label10.Text = $"LKR {stats.InventoryValue:N2}";

            //label11.Text = stats.LowStockProducts.ToString();

            //label12.Text = stats.TodayMovements.ToString();
        }


        private async Task LoadCurrentStockAsync()
        {
            _currentStock = (await _inventoryService.GetCurrentStockAsync()).ToList();

            DisplayCurrentStock(_currentStock);
        }

        //StockTransactionDto
        private void DisplayCurrentStock(IEnumerable<InventorySummaryDto> data)
        {
            dgvProducts.Rows.Clear();

            foreach (var item in data)
            {
                dgvProducts.Rows.Add(
                    item.CategoryName,
                    item.ProductName,
                    item.UnitCode,
                    item.GrossWeight.ToString("N2"),
                    item.AveragePrice.ToString("N2"),
                    item.TotalPrice.ToString("N2")
                );
            }
        }


        private void DisplayCurrentStock(IEnumerable<StockTransactionDto> data)
        {
            dataGridView1.Rows.Clear();

            foreach (var item in data)
            {
                dataGridView1.Rows.Add(
                    item.ReferenceNo,
                    item.CategoryName,
                    item.ProductName,
                    item.UnitCode,
                    item.Quantity.ToString("N2"),
                    item.GrossWeight.ToString("N2"),
                    item.UnitPrice.ToString("N2"),
                    item.TotalAmount.ToString("N2"),
                    item.TransactionDate.ToString("dd/MM/yyyy hh:mm tt")
                );
            }
        }

        private void DisplayOutStock(IEnumerable<StockTransactionDto> data)
        {
            dataGridView2.Rows.Clear();

            foreach (var item in data)
            {
                dataGridView2.Rows.Add(
                    item.ReferenceNo,
                    item.CategoryName,
                    item.ProductName,
                    item.UnitCode,
                    item.Quantity.ToString("N2"),
                    item.GrossWeight.ToString("N2"),
                    item.UnitPrice.ToString("N2"),
                    item.TotalAmount.ToString("N2"),
                    item.TransactionDate.ToString("dd/MM/yyyy hh:mm tt")
                );
            }
        }

        private void DisplayInventry(IEnumerable<StockTransactionDto> data)
        {
            dataGridView3.Rows.Clear();

            foreach (var item in data)
            {
                dataGridView3.Rows.Add(
                    item.ReferenceNo,
                    item.CategoryName,
                    item.ProductName,
                    item.UnitCode,
                    item.Quantity.ToString("N2"),
                    item.GrossWeight.ToString("N2"),
                    item.UnitPrice.ToString("N2"),
                    item.TotalAmount.ToString("N2"),
                    item.TransactionDate.ToString("dd/MM/yyyy hh:mm tt")
                );
            }
        }

        private async Task LoadStockInAsync()
        {
            DateTime startingDate = dateTimePicker1.Value.Date;
            DateTime endingDate = dateTimePicker2.Value.Date;

            _stockIn = (await _inventoryService.GetStockInAsync(startingDate, endingDate)).ToList();

            DisplayTransactions(dataGridView1, _stockIn);
        }


        private async Task LoadStockOutAsync()
        {
            DateTime startingDate = dateTimePicker4.Value.Date;
            DateTime endingDate = dateTimePicker3.Value.Date;

            _stockOut = (await _inventoryService.GetStockOutAsync(startingDate, endingDate)).ToList();

            DisplayTransactions(dataGridView2, _stockOut);
        }


        private async Task LoadLedgerAsync()
        {
            DateTime startingDate = dateTimePicker6.Value.Date;
            DateTime endingDate = dateTimePicker5.Value.Date;

            _ledger = (await _inventoryService.GetLedgerAsync(startingDate, endingDate)).ToList();

            DisplayTransactions(dataGridView3, _ledger);
        }

        private void DisplayTransactions(DataGridView grid, IEnumerable<StockTransactionDto> data)
        {
            grid.Rows.Clear();

            foreach (var item in data)
            {
                grid.Rows.Add(
                    item.ReferenceNo,
                    item.CategoryName,
                    item.ProductName,
                    item.UnitCode,
                    //item.TransactionType,
                    item.Quantity.ToString("N2"),
                    item.GrossWeight.ToString("N2"),
                    item.UnitPrice.ToString("N2"),
                    item.TotalAmount.ToString("N2"),
                    item.TransactionDate.ToString("dd/MM/yyyy hh:mm tt")
                );
            }
        }


        private async Task LoadCategoriesAsync()
        {
            var categories = await _inventoryService.GetCategoriesAsync();

            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("All");
            cmbCategory1.Items.Add("All");
            cmbCategory2.Items.Add("All");
            cmbCategory3.Items.Add("All");

            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category);
                cmbCategory1.Items.Add(category);
                cmbCategory2.Items.Add(category);
                cmbCategory3.Items.Add(category);
            }

            cmbCategory.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterCurrentStock();
        }


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCurrentStock();
        }


        private void FilterCurrentStock()
        {
            string search = txtSearch.Text.Trim().ToLower();

            string category = cmbCategory.SelectedItem?.ToString() ?? "All";


            var filtered = _currentStock.Where(x =>
                        (
                            string.IsNullOrWhiteSpace(search)
                            ||
                            x.ProductName.ToLower().Contains(search)
                        )
                        &&
                        (
                            category == "All"
                            ||
                            x.CategoryName == category
                        )
                    )
                    .ToList();


            DisplayCurrentStock(filtered);
        }

        private void FilterInStock()
        {
            string search = txtSearch1.Text.Trim().ToLower();

            string category = cmbCategory1.SelectedItem?.ToString() ?? "All";


            var filtered = _stockIn.Where(x =>
                        (
                            string.IsNullOrWhiteSpace(search)
                            ||
                            x.ProductName.ToLower().Contains(search)
                        )
                        &&
                        (
                            category == "All"
                            ||
                            x.CategoryName == category
                        )
                    )
                    .ToList();


            DisplayCurrentStock(filtered);
        }

        private void FilterOutStock()
        {
            string search = txtSearch2.Text.Trim().ToLower();

            string category = cmbCategory2.SelectedItem?.ToString() ?? "All";


            var filtered = _stockOut.Where(x =>
                        (
                            string.IsNullOrWhiteSpace(search)
                            ||
                            x.ProductName.ToLower().Contains(search)
                        )
                        &&
                        (
                            category == "All"
                            ||
                            x.CategoryName == category
                        )
                    )
                    .ToList();


            DisplayOutStock(filtered);
        }

        private void FilterInventy()
        {
            string search = txtSearch3.Text.Trim().ToLower();

            string category = cmbCategory3.SelectedItem?.ToString() ?? "All";


            var filtered = _ledger.Where(x =>
                        (
                            string.IsNullOrWhiteSpace(search)
                            ||
                            x.ProductName.ToLower().Contains(search)
                        )
                        &&
                        (
                            category == "All"
                            ||
                            x.CategoryName == category
                        )
                    )
                    .ToList();


            DisplayInventry(filtered);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                await RefreshAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshAllAsync()
        {
            await LoadDashboardCardsAsync();

            await LoadCurrentStockAsync();

            await LoadStockInAsync();

            await LoadStockOutAsync();

            await LoadLedgerAsync();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            // If PurchaseForm is your stock-in screen,
            // open it here.

            /*
            using var form =
                new PurchaseForm();

            form.ShowDialog();

            if (form.DialogResult ==
                DialogResult.OK)
            {
                await RefreshAllAsync();
            }
            */
        }


        private void btnAdjustments_Click(object sender, EventArgs e)
        {
            /*
            using var form =
                new StockAdjustmentForm(
                    _inventoryService);

            if (form.ShowDialog() ==
                DialogResult.OK)
            {
                await RefreshAllAsync();
            }
            */
        }


        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dgvProducts.Rows[e.RowIndex];

            // You can get selected product here
        }


        // =========================================================
        // UNUSED DESIGNER EVENTS
        // =========================================================

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void cardMovements_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabCurrentStock_Click(object sender, EventArgs e)
        {

        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            await LoadStockInAsync();
        }

        private async void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            await LoadStockInAsync();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            await LoadStockOutAsync();
        }

        private async void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            await LoadStockOutAsync();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FilterCurrentStock();
        }

        private void txtSearch_TextChanged_2(object sender, EventArgs e)
        {
            FilterCurrentStock();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInStock();
        }

        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            FilterInStock();
        }

        private void cmbCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterOutStock();
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            FilterOutStock();
        }

        private async void dateTimePicker6_ValueChanged(object sender, EventArgs e)
        {
            await LoadLedgerAsync();
        }

        private async void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {
            await LoadLedgerAsync();
        }

        private void txtSearch3_TextChanged(object sender, EventArgs e)
        {
            FilterInventy();
        }

        private void cmbCategory3_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterInventy();
        }
    }
}
