using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.Entities;
using HardwarePOS.Shared.Helpers;
using HardwarePOS.UI.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwarePOS.UI.Forms
{
    public partial class CashForm : Form
    {
        private readonly string _transactionType;
        private readonly CashService _cashService;
        private int DaySessionId;

        public CashForm(string transactionType)
        {
            InitializeComponent();

            _transactionType = transactionType;

            Shown += CashForm_Shown;

            var factory = ConnectionService.CreateFactory();
            var crepository = new CashRepository(factory);
            _cashService = new CashService(crepository);

            GetDaySesstion0();
        }

        private async void CashForm_Shown(object sender, EventArgs e)
        {
            await InitializeFormAsync();
        }

        public async void GetDaySesstion0()
        {
            DaySessionId = await _cashService.GetDaySesstion();

        }

        private async Task InitializeFormAsync()
        {
            dtTransactionDate.Value = DateTime.Now;
            dtTransactionDate.Enabled = false;

            if (_transactionType == "CASH_IN")
            {
                lblTitle.Text = "CASH IN";
                btnSave.Text = "CASH IN";
                btnSave.BackColor = Color.FromArgb(46, 204, 113);
                Text = "Cash In";
            }
            else
            {
                lblTitle.Text = "CASH OUT";
                btnSave.Text = "CASH OUT";
                btnSave.BackColor = Color.Firebrick;
                btnSave.TextAlign = ContentAlignment.MiddleCenter;
                Text = "Cash Out";
            }

            await LoadCategoriesAsync();
            await LoadCurrentCashBalanceAsync();
        }

        private async void CashForm_Load(object sender, EventArgs e)
        {
            dtTransactionDate.Value = DateTime.Now;
            dtTransactionDate.Enabled = false;

            if (_transactionType == "CASH_IN")
            {
                lblTitle.Text = "CASH IN";

                btnSave.Text = "SAVE CASH IN";

                btnSave.BackColor = Color.FromArgb(46, 204, 113);

                Text = "Cash In";
            }
            else
            {
                lblTitle.Text = "CASH OUT";

                btnSave.Text = "SAVE CASH OUT";

                btnSave.BackColor = Color.Firebrick;

                Text = "Cash Out";
            }

            await LoadCategoriesAsync();

            await LoadCurrentCashBalanceAsync();
        }

        private async Task LoadCategoriesAsync()
        {
            // TODO:
            // Replace this with your service
            //
            // var list = await _cashCategoryService.GetByTypeAsync(_transactionType);

            cmbCategory.Items.Clear();

            if (_transactionType == "CASH_IN")
            {
                cmbCategory.Items.Add("Opening Balance");
                cmbCategory.Items.Add("Customer Payment");
                cmbCategory.Items.Add("Owner Investment");
                cmbCategory.Items.Add("Other Income");
            }
            else
            {
                cmbCategory.Items.Add("Supplier Payment");
                cmbCategory.Items.Add("Salary");
                cmbCategory.Items.Add("Electricity");
                cmbCategory.Items.Add("Water Bill");
                cmbCategory.Items.Add("Transport");
                cmbCategory.Items.Add("Office Expense");
                cmbCategory.Items.Add("Other Expense");
            }

            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;

            await Task.CompletedTask;
        }

        private async Task LoadCurrentCashBalanceAsync()
        {
            // TODO:
            // Replace with DashboardService

            decimal currentBalance = await _cashService.GetCurrentCashAsync(DaySessionId);

            txtCurrentBalance.Text = currentBalance.ToString("N2");

            await Task.CompletedTask;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (numAmount.Value <= 0)
            {
                MessageBox.Show("Enter Amount.");

                return;
            }

            // TODO
            // CashTransaction cash = new CashTransaction()
            // {
            //     TransactionDate = dtTransactionDate.Value,
            //     TransactionType = _transactionType,
            //     Category = cmbCategory.Text,
            //     Amount = numAmount.Value,
            //     ReferenceNo = txtReference.Text,
            //     Remarks = txtRemarks.Text,
            //     CreatedBy = UserSession.CurrentUser!.StaffId
            // };
            //
            // await _cashService.SaveAsync(cash);

            

            CashTransaction cash = new()
            {
                TransactionDate = dtTransactionDate.Value,

                TransactionType = _transactionType,

                Category = cmbCategory.Text,

                Amount = numAmount.Value,

                ReferenceNo = txtReference.Text,

                Remarks = txtRemarks.Text,

                CreatedBy = UserSession.CurrentUser!.StaffId,

                DaySessionId = DaySessionId
            };

            await _cashService.SaveAsync(cash);

        

            MessageBox.Show("Cash transaction saved successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;

            Close();

            await Task.CompletedTask;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void CashForm_Load_1(object sender, EventArgs e)
        {

        }

    }
}