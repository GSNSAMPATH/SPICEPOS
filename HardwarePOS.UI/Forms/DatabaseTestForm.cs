using HardwarePOS.UI.Services;

namespace HardwarePOS.UI.Forms
{
    public partial class DatabaseTestForm : Form
    {
        public DatabaseTestForm()
        {
            InitializeComponent();
        }

        private void DatabaseTestForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Create factory
                var factory = ConnectionService.CreateFactory();

                // Create SQL connection
                using var connection = factory.CreateConnection();

                // Open connection
                connection.Open();

                MessageBox.Show(
                    "Database Connected Successfully",
                    "SUCCESS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "DATABASE ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}