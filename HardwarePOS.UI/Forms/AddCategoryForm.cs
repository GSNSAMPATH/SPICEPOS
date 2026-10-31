
using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;


namespace HardwarePOS.UI.Forms
{
    public partial class AddCategoryForm : BaseForm
    {
        private string categoryName = string.Empty;
        private string categorydescription = string.Empty;
        public int CreatedCategoryId{get;private set;}

        private readonly CategoryService _categoryService;

        public AddCategoryForm()
        {
            InitializeComponent();
            var factory = ConnectionService.CreateFactory();

            var repository = new CategoryRepository(factory);
            _categoryService = new CategoryService(repository);
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            categoryName = NameBox.Text.Trim();
        }
        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            categorydescription = DescriptionBox.Text.Trim();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

        }

        //private CategoryService Get_categoryService1()
        //{
        //    return _categoryService;
        //}

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(categoryName))
                {
                    MessageBox.Show("Failed to add Category. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    return;
                }

                CreatedCategoryId = await _categoryService.AddCategoryAsync(categoryName, categorydescription);

                if (CreatedCategoryId > 0)
                {
                    MessageBox.Show("Successfully added Category!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
