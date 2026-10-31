using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;

namespace HardwarePOS.UI.Forms
{
    public partial class ProductsForm : BaseForm
    {
        private readonly ProductService
            _productService;

        public ProductsForm()
        {
            InitializeComponent();

            var factory =
                ConnectionService.CreateFactory();

            var repository =
                new ProductRepository(factory);

            _productService =
                new ProductService(repository);

            Load += ProductsForm_Load;
        }

        private async void ProductsForm_Load(
            object sender,
            EventArgs e)
        {
            await LoadProductsAsync();
            WindowState =
    FormWindowState.Maximized;
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                dgvProducts.Rows.Clear();

                var products =
                    await _productService
                        .GetProductsAsync();

                foreach (var product in products)
                {
                    dgvProducts.Rows.Add(
                        product.ProductId,
                        product.CategoryName,
                        product.ProductName,
                        product.UnitName,
                        product.AveragePrice.ToString("N2"),
                        product.CurrentStock.ToString("N2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditProductForm();

            form.ShowDialog();
        }

        private async void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            await LoadProductsAsync();
        }

        private void btnDelete_Click(
            object sender,
            EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Select a product first");

                return;
            }

            MessageBox.Show(
                "Delete Product Logic Coming Next");
        }

        private async void txtSearch_TextChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                string keyword =
                    txtSearch.Text
                        .Trim()
                        .ToLower();

                dgvProducts.Rows.Clear();

                var products =
                    await _productService
                        .GetProductsAsync();

                var filtered =
                    products.Where(p =>
                        p.ProductName
                            .ToLower()
                            .Contains(keyword)

                        ||

                        //p.Barcode
                        //    .ToLower()
                        //    .Contains(keyword)

                        //||

                        p.CategoryName
                            .ToLower()
                            .Contains(keyword))
                    .ToList();

                foreach (var product in filtered)
                {
                    dgvProducts.Rows.Add(
                        product.ProductId,
                        //product.Barcode,
                        product.CategoryName,
                        product.ProductName,
                        //product.BrandName,
                        product.SellingPrice.ToString("N2"),
                        product.CurrentStock.ToString("N2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProducts_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsForm_Load_2(object sender, EventArgs e)
        {

        }
    }
}