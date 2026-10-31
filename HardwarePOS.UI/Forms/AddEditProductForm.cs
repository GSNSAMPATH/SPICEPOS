using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;
using HardwarePOS.Shared.Helpers;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;


namespace HardwarePOS.UI.Forms
{
    public partial class AddEditProductForm : Form
    {
        private int CreatedProductId;

        private readonly ProductService _productService;


        public AddEditProductForm()
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();

            var repository = new ProductRepository(factory);

            _productService = new ProductService(repository);

            LoadDropdownsAsync();

        }


        private async Task LoadDropdownsAsync()
        {
            try
            {

                var categories = await _productService.GetCategoriesAsync();

                cmbCategory.DataSource = categories;

                cmbCategory.DisplayMember = "CategoryName";

                cmbCategory.ValueMember = "CategoryId";


                var units = await _productService.GetUnitsAsync();

                cmbUnit.DataSource = units;

                cmbUnit.DisplayMember = "UnitName";

                cmbUnit.ValueMember = "UnitId";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCancel_Click(object sender,EventArgs e)
        {
            Close();
        }

        private void AddEditProductForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var form = new AddCategoryForm();

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadDropdownsAsync();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new AddUnitForm();

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadDropdownsAsync();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new AddSuppliersForm();

            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadDropdownsAsync();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescriptoon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericCostPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericSellingPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericWholesePrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericRecordLevel_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericOpenStock_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textRackLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxActive_CheckedChanged(object sender, EventArgs e)
        {

        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = textProductCode.Text.Trim();

                string productName = textProductName.Text.Trim();

                string description = textDescriptoon.Text.Trim();


                bool isActive = checkBoxActive.Checked;

                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Product name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textProductName.Focus();
                    return;
                }

                if (cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Select category");
                    return;
                }

                if (cmbUnit.SelectedValue == null)
                {
                    MessageBox.Show("Select unit");
                    return;
                }

                Product product = new()
                {
                    ProductName = productName,

                    CategoryId = (int)cmbCategory.SelectedValue,

                    UnitId = (int)cmbUnit.SelectedValue,

                    CreatedBy = UserSession.StaffId
                };

                btnSave.Enabled = false;

                CreatedProductId = await _productService.AddProductAsync(product);

                if (CreatedProductId <= 0)
                {
                    MessageBox.Show("Failed to add product.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Product added successfully.", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"System Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }
    }
}