using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;
using HardwarePOS.Shared.Helpers;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;

namespace HardwarePOS.UI.Forms
{
    public partial class LoginForm : BaseForm
    {
        private readonly AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();

            var userRepository = new UserRepository(factory);

            _authService = new AuthService(userRepository);
        }

        private async void btnLogin_Click(object sender,EventArgs e)
        {
            try
            {
                btnLogin.Enabled = false;

                string username = txtUsername.Text.Trim();

                string password = txtPassword.Text;

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Enter username");
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Enter password");
                    return;
                }

                
                var user = await _authService.LoginAsync(username,password);

                Console.WriteLine(username + " " + password);

                if (user == null)
                {
                    MessageBox.Show("Invalid username or password","Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    return;
                }

                UserSession.Login(user);



                Hide();

                var dashboard = new DashboardForm();

                dashboard.ShowDialog();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender,EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}