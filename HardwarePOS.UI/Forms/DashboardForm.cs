using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;
using HardwarePOS.Shared.Helpers;
using HardwarePOS.UI.Services;

namespace HardwarePOS.UI.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly DaySessionService _daysessionService;
        public DashboardForm()
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();
            var srepository = new DaySessionRepository(factory);
            _daysessionService = new DaySessionService(srepository);

            lblUsername.Text = UserSession.CurrentUser?.FullName; OpenChildForm(new HomeForm());
        }

        private Form? activeForm;

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;

            childForm.FormBorderStyle =
                FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();

            pnlContent.Controls.Add(childForm);

            pnlContent.Tag = childForm;

            childForm.BringToFront();

            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductsForm());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InventoryForm());
        }

        private async void btnPOS_Click(object sender, EventArgs e)
        {

            bool dayStarted = await _daysessionService.IsDayOpenAsync();

            if (!dayStarted)
            {
                string currentUserName = UserSession.UserName;
                int currentUserId = UserSession.StaffId;
                var form = new DaySessionForm(currentUserId, currentUserName);

                DialogResult result = form.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    OpenChildForm(new POSForm());
                }
            }

            else
            {
                OpenChildForm(new POSForm());
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserSession.Logout();

            Hide();

            new LoginForm().ShowDialog();

            Close();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            bool dayStarted = await _daysessionService.IsDayOpenAsync();

            if (!dayStarted)
            {
                string currentUserName = UserSession.UserName;
                int currentUserId = UserSession.StaffId;
                var form = new DaySessionForm(currentUserId, currentUserName);

                DialogResult result = form.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    OpenChildForm(new SalesPosForm());
                }
            }

            else
            {
                OpenChildForm(new SalesPosForm());
            }


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            bool dayStarted = await _daysessionService.IsDayOpenAsync();

            string currentUserName = UserSession.UserName;
            int currentUserId = UserSession.StaffId;

            if (!dayStarted)
            {

                var form = new DaySessionForm(currentUserId, currentUserName);

                DialogResult result = form.ShowDialog(this);


            }

            else
            {

                var form = new DaySessionForm(currentUserId, currentUserName);
                DialogResult result = form.ShowDialog(this);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            bool dayStarted = await _daysessionService.IsDayOpenAsync();

            if (!dayStarted)
            {
                string currentUserName = UserSession.UserName;
                int currentUserId = UserSession.StaffId;
                var form = new DaySessionForm(currentUserId, currentUserName);

                DialogResult result = form.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    OpenChildForm(new ChashInOutForm());
                }
            }

            else
            {
                OpenChildForm(new ChashInOutForm());
            }

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            bool dayStarted = await _daysessionService.IsDayOpenAsync();

            if (!dayStarted)
            {
                string currentUserName = UserSession.UserName;
                int currentUserId = UserSession.StaffId;
                var form = new DaySessionForm(currentUserId, currentUserName);

                DialogResult result = form.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    OpenChildForm(new CancelbillForm());
                }
            }

            else
            {
                OpenChildForm(new CancelbillForm());
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}