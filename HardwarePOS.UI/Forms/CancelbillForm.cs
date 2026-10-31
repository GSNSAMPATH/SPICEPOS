using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Shared.Helpers;
using HardwarePOS.UI.Services;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwarePOS.UI.Forms
{
    public partial class CancelbillForm : Form
    {
        private readonly TransactionService _transactionService;


        public CancelbillForm()
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();
            var repository = new TransactionRepository(factory);
            _transactionService = new TransactionService(repository);

            Load += CancelbillForm_Load;

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private async void CancelbillForm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("ALL");
            cmbCategory.Items.Add("SALE");
            cmbCategory.Items.Add("PURCHASE");

            cmbCategory.SelectedIndex = 0;

            dateTimePicker4.Value = DateTime.Today.AddDays(-30);
            dateTimePicker3.Value = DateTime.Today;

            LoadTransactionsAsync();

        }

        private async Task LoadTransactionsAsync()
        {
            try
            {
                string? type = cmbCategory.Text == "ALL" ? null : cmbCategory.Text;

                string? search = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text.Trim();

                List<TransactionHistory> transactions = await _transactionService.GetTransactionsAsync(type, dateTimePicker4.Value.Date, dateTimePicker3.Value.Date, search);

                dgvProducts.Rows.Clear();

                foreach (var item in transactions)
                {
                    dgvProducts.Rows.Add(
                        item.Id,
                        item.TransactionType,
                        item.InvoiceNo,
                        item.TransactionDate.ToString("dd/MM/yyyy HH:mm"),
                        item.TotalAmount.ToString("N2"),
                        item.PaymentMethod,
                        item.PaidAmount.ToString("N2"),
                        item.BalanceAmount.ToString("N2"),
                        item.Status,
                        item.CreatedBy
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker4.Value.Date > dateTimePicker3.Value.Date)
                return;

            await LoadTransactionsAsync();
        }

        private async void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker4.Value.Date > dateTimePicker3.Value.Date)
                return;

            await LoadTransactionsAsync();
        }

        private async void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadTransactionsAsync();
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await LoadTransactionsAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Please select a bill first.", "Cancel Bill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);

            string type = dgvProducts.CurrentRow.Cells["dataGridViewTextBoxColumn3"].Value?.ToString() ?? "";

            string invoiceNo = dgvProducts.CurrentRow.Cells["dataGridViewTextBoxColumn4"].Value?.ToString() ?? "";

            string status = dgvProducts.CurrentRow.Cells["Column4"].Value?.ToString() ?? "";

            if (status.Equals("CANCELLED", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("This bill is already cancelled.", "Cancel Bill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var authorization = ShowCancelAuthorizationDialog();

            if (authorization == null)
                return;

            string password = authorization.Password;
            string reason = authorization.Reason;

            if (string.IsNullOrEmpty(password))
                return;

            if (password != "1234")
            {
                MessageBox.Show("Incorrect authorization password.", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to cancel this bill?\n\n" +
                $"Type: {type}\n" +
                $"Invoice: {invoiceNo}",
                "Confirm Bill Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                if (string.IsNullOrWhiteSpace(reason))
                    return;

                await _transactionService.VoidTransactionAsync(type, id, UserSession.CurrentUser.StaffId, reason);

                MessageBox.Show("Bill cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadTransactionsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private CancelAuthorizationResult? ShowCancelAuthorizationDialog()
        {
            using Form form = new Form();

            form.Text = "Cancel Bill Authorization";
            form.Size = new Size(430, 330);
            form.StartPosition = FormStartPosition.CenterParent;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.MaximizeBox = false;
            form.MinimizeBox = false;

            // Password Label
            Label lblPassword = new Label
            {
                Text = "Enter authorization password:",
                Location = new Point(25, 25),
                AutoSize = true,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold)
            };

            // Password
            TextBox passwordBox = new TextBox
            {
                Location = new Point(25, 60),
                Size = new Size(360, 32),
                UseSystemPasswordChar = true,
                Font = new Font("Segoe UI", 12F)
            };

            // Reason Label
            Label lblReason = new Label
            {
                Text = "Cancellation reason:",
                Location = new Point(25, 105),
                AutoSize = true,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold)
            };

            // Reason
            TextBox reasonBox = new TextBox
            {
                Location = new Point(25, 140),
                Size = new Size(360, 70),
                Multiline = true,
                Font = new Font("Segoe UI", 11F),
                ScrollBars = ScrollBars.Vertical
            };

            // Authorize
            Button btnOK = new Button
            {
                Text = "Authorize",
                Location = new Point(180, 230),
                Size = new Size(100, 35),
                DialogResult = DialogResult.OK
            };

            // Cancel
            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(285, 230),
                Size = new Size(100, 35),
                DialogResult = DialogResult.Cancel
            };

            form.Controls.Add(lblPassword);
            form.Controls.Add(passwordBox);
            form.Controls.Add(lblReason);
            form.Controls.Add(reasonBox);
            form.Controls.Add(btnOK);
            form.Controls.Add(btnCancel);

            form.AcceptButton = btnOK;
            form.CancelButton = btnCancel;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(passwordBox.Text))
                {
                    MessageBox.Show(
                        "Authorization password is required.",
                        "Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return ShowCancelAuthorizationDialog();
                }

                if (string.IsNullOrWhiteSpace(reasonBox.Text))
                {
                    MessageBox.Show(
                        "Cancellation reason is required.",
                        "Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return ShowCancelAuthorizationDialog();
                }

                return new CancelAuthorizationResult
                {
                    Password = passwordBox.Text,
                    Reason = reasonBox.Text.Trim()
                };
            }

            return null;
        }

        private void CancelbillForm_Load_1(object sender, EventArgs e)
        {

        }
    }

    public class CancelAuthorizationResult
    {
        public string Password { get; set; } = string.Empty;
        public string Reason { get; set; } = string.Empty;
    }
}
