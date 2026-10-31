using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.UI.Services;
using System.Data;

namespace HardwarePOS.UI.Forms
{
    public partial class HomeForm : Form
    {
        private readonly DashboardService
            _dashboardService;

        public HomeForm()
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();

            var repository = new DashboardRepository(factory);

            _dashboardService = new DashboardService(repository);

            Load += HomeForm_Load;

            LoadDashboardSummary();
        }

        private async void HomeForm_Load(
            object sender,
            EventArgs e)
        {
            await LoadDashboardAsync();
        }

        private async Task LoadDashboardAsync()
        {
            try
            {
                var stats = await _dashboardService.GetStatsAsync();

                lblPurchasAmount.Text = $"LKR {stats.TodayPurchaseAmount:N2}";

                lblsalseamount.Text = $"LKR {stats.TodaySalesAmount:N2}";

                lblProfit.Text = $"LKR {stats.CurrentCash:N2}";

                lblInventryvalue.Text = $"LKR {stats.InventoryValue:N2}";

                //lblTotalStock.Text =stats.ProductsInStock.ToString();

                //lblHolds.Text =
                //    stats.PendingHolds.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task LoadDashboardSummary()
        {
            dataGridView1.Rows.Clear();

            var products = await _dashboardService.GetProductSummaryAsync();

            foreach (var item in products)
            {
                dataGridView1.Rows.Add(
                    item.ProductId,
                    item.CategoryName,
                    item.ProductName,
                    item.GrossWeight,
                    item.TareWeight,
                    item.WetWeight,
                    item.NetWeight,
                    item.AveragePrice,
                    $"{item.TotalPrice:N2}"
                );
            }
        }

        private void HomeForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeForm_Load_2(object sender, EventArgs e)
        {

        }
    }
}