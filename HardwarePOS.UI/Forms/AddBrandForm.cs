using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;


namespace HardwarePOS.UI.Forms
{
    public partial class AddBrandForm : BaseForm
    {
        private string brandName = string.Empty;
        public int CreatedBrandId { get; private set; }

        private readonly BrandService _brandService;

        public AddBrandForm()
        {
            InitializeComponent();
            var factory = ConnectionService.CreateFactory();
            var repository = new BrandRepository(factory);
            _brandService = new BrandService(repository);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBrandForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(NameBox, "");

            brandName = NameBox.Text;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (string.IsNullOrWhiteSpace(brandName))
                {
                    MessageBox.Show("Enter Brand name");
                    return;
                }

                CreatedBrandId = await _brandService.AddBrandAsync(brandName);

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
