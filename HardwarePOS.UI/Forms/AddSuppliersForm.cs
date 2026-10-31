using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;


namespace HardwarePOS.UI.Forms
{
    public partial class AddSuppliersForm : BaseForm
    {
        private string suppliersName = string.Empty;
        private string suppliersContact = string.Empty;
        private string suppliersEmail = string.Empty;
        private string suppliersAddress = string.Empty;

        public int CreatedSupplierId { get; private set; }

        private readonly SupplierServices _supplierServices;

        public AddSuppliersForm()
        {
            InitializeComponent();
            var factory = ConnectionService.CreateFactory();

            var repository = new SupplierRepository(factory);
            _supplierServices = new SupplierServices(repository);
        }

        private void AddSuppliersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            suppliersName = NameBox.Text;
        }

        private void Phon_NumberBox_TextChanged(object sender, EventArgs e)
        {
            suppliersContact = Phon_NumberBox.Text;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            suppliersEmail = EmailBox.Text;
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            suppliersAddress = AddressBox.Text;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(suppliersName))
                {
                    MessageBox.Show("Failed to add Supplier. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                CreatedSupplierId = await _supplierServices.AddSupplierAsync(suppliersName, suppliersContact, suppliersEmail, suppliersAddress);

                if (CreatedSupplierId > 0)
                {
                    MessageBox.Show("Successfully added Supplier!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
