using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.UI.Services;
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
    public partial class ChashInOutForm : Form
    {
        private readonly CashService _cashService;
        public ChashInOutForm()
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();
            var crepository = new CashRepository(factory);
            _cashService = new CashService(crepository);


        }

        private void ChashInOutForm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("All");
            cmbCategory.Items.Add("CASH_IN");
            cmbCategory.Items.Add("CASH_OUT");

            cmbCategory.SelectedIndex = 0;

            //LoadCashFlowAsync();
        }

        private async Task LoadCashFlowAsync()
        {
            dgvProducts.Rows.Clear();

            string? type = null;

            if (cmbCategory.SelectedIndex > 0)
                type = cmbCategory.Text;

            var list = await _cashService.GetCashFlowAsync(
                type,
                dateTimePicker4.Value.Date,
                dateTimePicker3.Value.Date,
                txtSearch.Text.Trim());

            foreach (var item in list)
            {
                dgvProducts.Rows.Add(
                    item.CashTransactionId,
                    item.TransactionDate.ToString("dd/MM/yyyy HH:mm"),
                    item.TransactionType,
                    item.Category,
                    item.Amount.ToString("N2"),
                    item.ReferenceNo,
                    item.Remarks,
                    item.CreatedByName,
                    item.DaySessionDate
                );
            }
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await LoadCashFlowAsync();
        }

        //private async void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    await LoadCashFlowAsync();
        //}

        private async void dateTimePicker4_ValueChanged_1(object sender, EventArgs e)
        {
            await LoadCashFlowAsync();
        }

        private async void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            await LoadCashFlowAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadCashFlowAsync();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var frm = new CashForm("CASH_IN"))
            {
                frm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var frm = new CashForm("CASH_OUT"))
            {
                frm.ShowDialog();
            }
        }

        private async void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            await LoadCashFlowAsync();
        }
    }
}
