
using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;

namespace HardwarePOS.UI.Forms
{
    public partial class AddUnitForm : BaseForm
    {
        private string unitName = string.Empty;
        private string shortName = string.Empty;
        public int CreatedUnitId { get; private set; }
        private readonly UnitService _unitService;

        public AddUnitForm()
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();
            var repository = new UnitRepository(factory);
            _unitService = new UnitService(repository);
        }

        private void AddUnitForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            unitName = NameBox.Text;

        }

        private void ShortNameBox_TextChanged(object sender, EventArgs e)
        {
            shortName = NameBox.Text;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(unitName))
                {
                    MessageBox.Show("Enter UnitName name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(shortName))
                {
                    MessageBox.Show("Enter ShortName name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                CreatedUnitId = await _unitService.AddUnitAsync(unitName, shortName);

                MessageBox.Show("Successfully added Category!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
