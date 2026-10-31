using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;
using HardwarePOS.UI.Services;
using HardwarePOS.UI.Helpers;

namespace HardwarePOS.UI.Forms
{
    public partial class AddNewStockForm1 : BaseForm
    {
        //private readonly PurchaseService _purchaseService;
        private readonly ProductService _productService;
        private readonly SupplierServices _supplierService;
        private bool _isLoading;
        private List<Product> _products = new();

        public AddNewStockForm1()
        {
            InitializeComponent();
            var factory = ConnectionService.CreateFactory();

            //_purchaseService =
            //    new PurchaseService(
            //        new PurchaseRepository(factory));

            _productService =
                new ProductService(
                    new ProductRepository(factory));

            _supplierService = new SupplierServices(new SupplierRepository(factory));

        }

        private async void AddNewStockForm1_Load(object sender, EventArgs e)
        {
            await LoadSuppliersAsync();

            await LoadProductsAsync();

            if (_products.Count > 0)
            {
                LoadProductDetails(
                    _products[0].ProductId);
            }

            GenerateStockInNumber();

            CalculateTotal();
        }

        private void GenerateStockInNumber()
        {
            textStockInNo.Text =
                $"SIN-{DateTime.Now:yyyyMMddHHmmss}";
        }

        private async Task LoadSuppliersAsync()
        {
            var suppliers = await _supplierService.GetAllAsync();

            cmbSupplier.DataSource = suppliers;

            cmbSupplier.DisplayMember = "SupplierName";

            cmbSupplier.ValueMember = "SupplierId";
        }

        private async Task LoadProductsAsync()
        {
            _isLoading = true;

            _products = await _productService.GetAllProductsAsync();

            if (!_products.Any())
            {
                MessageBox.Show(
                    "No products found.");

                return;
            }

            cmbProductCode.DataSource = _products.ToList();

            cmbProductCode.DisplayMember = "ProductCode";

            cmbProductCode.ValueMember = "ProductId";

            cmbProductName.DataSource = _products.ToList();

            cmbProductName.DisplayMember = "ProductName";

            cmbProductName.ValueMember = "ProductId";

            _isLoading = false;
        }

        private void cmbProductCode_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (_isLoading)
                return;

            if (cmbProductCode.SelectedValue == null)
                return;

            if (!int.TryParse(
                cmbProductCode.SelectedValue.ToString(),
                out int productId))
            {
                return;
            }

            _isLoading = true;

            cmbProductName.SelectedValue =
                productId;

            LoadProductDetails(productId);

            _isLoading = false;
        }

        private void cmbProductName_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (_isLoading)
                return;

            if (cmbProductName.SelectedValue == null)
                return;

            if (!int.TryParse(
                cmbProductName.SelectedValue.ToString(),
                out int productId))
            {
                return;
            }

            _isLoading = true;

            cmbProductCode.SelectedValue =
                productId;

            LoadProductDetails(productId);

            _isLoading = false;
        }

        private void LoadProductDetails(int productId)
        {
            var product = _products.FirstOrDefault(
                    x => x.ProductId == productId);

            if (product == null)
                return;

            CalculateTotal();
        }


        //private void cmbProductCode_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbProductCode.SelectedItem is Product product)
        //    {
        //        cmbProductName.SelectedValue = product.ProductId;

        //        textUnit.Text = product.UnitName;

        //        numericCostPrice.Value = product.CostPrice;

        //        numericSellingPrice.Value = product.SellingPrice;
        //    }
        //}

        private void CalculateTotal()
        {
            decimal total =
    numericQty.Value *
    numericCostPrice.Value;

            numericTotal.Value =
                Math.Min(
                    total,
                    numericTotal.Maximum);
        }

        private void btnAddItem_Click(object sender,EventArgs e)
        {

            if (numericQty.Value <= 0)
            {
                MessageBox.Show(
                    "Enter quantity");

                return;
            }

            foreach (DataGridViewRow row
    in dgvProducts.Rows)
            {
                if (row.Cells[0].Value?.ToString()
                    == cmbProductCode.Text)
                {
                    MessageBox.Show(
                        "Product already added.");

                    return;
                }
            }

            dgvProducts.Rows.Add(
                cmbProductCode.Text,
                cmbProductName.Text,
                "",
                "",
                numericQty.Value,
                numericCostPrice.Value,
                numericSellingPrice.Value,
                numericTotal.Value);

            //CalculateGrandTotal();
        }

        private decimal GetGrandTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row
                in dgvProducts.Rows)
            {
                if (row.Cells[7].Value != null)
                {
                    total += Convert.ToDecimal(
                        row.Cells[7].Value);
                }
            }

            return total;
        }

        private async void btnSave_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                if (dgvProducts.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Add products first");

                    return;
                }

                // Save Purchase Invoice

                MessageBox.Show(
                    "Stock Added Successfully");

                DialogResult =
                    DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(
    object sender,
    EventArgs e)
        {
            Close();
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
