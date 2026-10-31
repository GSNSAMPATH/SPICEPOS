using HardwarePOS.Business.Services;
using HardwarePOS.Data.Repositories;
using HardwarePOS.Models.DTOs;
using HardwarePOS.Shared.Helpers;
using HardwarePOS.UI.Helpers;
using HardwarePOS.UI.Services;
using HardwarePOS.Business.Services;

namespace HardwarePOS.UI.Forms
{
    public partial class DaySessionForm : Form
    {
        private readonly DaySessionService _daySessionService;
        private readonly int _userId;
        private readonly string _userName;

        private DaySessionDto? _currentSession;

        public DaySessionForm(int userId,string userName)
        {
            InitializeComponent();

            var factory = ConnectionService.CreateFactory();
            var srepository = new DaySessionRepository(factory);
            _daySessionService = new DaySessionService(srepository);

            _userId = userId;
            _userName = userName;
        }

        private async void DaySessionForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblUser.Text = _userName;

                _currentSession =await _daySessionService.GetOpenSessionAsync();

                if (_currentSession == null)
                {
                    ShowStartDayMode();
                }
                else
                {
                    await ShowEndDayModeAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // ============================================
        // START DAY MODE
        // ============================================

        private void ShowStartDayMode()
        {
            lblTitle.Text = "START BUSINESS DAY";

            lblSubtitle.Text = "Enter the opening cash amount to start the business day.";

            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            lblTime.Text = DateTime.Now.ToString("hh:mm tt");

            lblUser.Text = _userName;

            // Start section
            pnlStartDay.Visible = true;

            // End section
            pnlEndDay.Visible = false;

            btnStartDay.Visible = true;
            btnEndDay.Visible = false;

            txtOpeningCash.Text = "0.00";

            txtOpeningCash.Focus();
        }

        // ============================================
        // END DAY MODE
        // ============================================

        private async Task ShowEndDayModeAsync()
        {
            if (_currentSession == null)
                return;

            lblTitle.Text = "END BUSINESS DAY";

            lblSubtitle.Text = "Review today's summary and close the business day.";

            lblDate.Text = _currentSession.OpenDateTime.ToString("dddd, dd MMMM yyyy");

            lblTime.Text = _currentSession.OpenDateTime.ToString("hh:mm tt");

            lblUser.Text = _userName;

            pnlStartDay.Visible = false;

            pnlEndDay.Visible = true;

            btnStartDay.Visible = false;

            btnEndDay.Visible = true;

            var summary = await _daySessionService.GetClosingSummaryAsync(_currentSession.DaySessionId);

            lblOpeningCashValue.Text = $"LKR {summary.OpeningCash:N2}";

            lblCashSalesValue.Text = $"LKR {summary.CashSales:N2}";

            lblPurchasePaymentsValue.Text = $"LKR {summary.PurchasePayments:N2}";


            lblCashInValue.Text = $"LKR {summary.CashIn:N2}";

            CashOutValue.Text = $"LKR {summary.CashOut:N2}";

            lblExpectedCashValue.Text = $"LKR {summary.ExpectedCash:N2}";

            txtActualCash.Text = summary.ExpectedCash.ToString("F2");

            // Force UI refresh
            pnlEndDay.Refresh();

            CalculateDifference();
        }

        // ============================================
        // START DAY
        // ============================================

        private async void btnStartDay_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(
                    txtOpeningCash.Text,
                    out decimal openingCash))
                {
                    MessageBox.Show(
                        "Please enter a valid opening cash amount.",
                        "Invalid Amount",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtOpeningCash.Focus();

                    return;
                }

                if (openingCash < 0)
                {
                    MessageBox.Show(
                        "Opening cash cannot be negative.",
                        "Invalid Amount",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var confirm =
                    MessageBox.Show(
                        $"Start the business day with " +
                        $"LKR {openingCash:N2}?",
                        "Confirm Day Start",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                btnStartDay.Enabled = false;

                int sessionId =
                    await _daySessionService
                        .StartDayAsync(
                            openingCash,
                            _userId);

                MessageBox.Show(
                    "Business day started successfully.",
                    "Day Started",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnStartDay.Enabled = true;
            }
        }

        // ============================================
        // ACTUAL CASH CHANGED
        // ============================================

        private void txtActualCash_TextChanged(
            object sender,
            EventArgs e)
        {
            CalculateDifference();
        }

        // ============================================
        // CALCULATE DIFFERENCE
        // ============================================

        private void CalculateDifference()
        {
            if (!decimal.TryParse(
                txtActualCash.Text,
                out decimal actualCash))
            {
                lblDifferenceValue.Text =
                    "LKR 0.00";

                return;
            }

            string expectedText =
                lblExpectedCashValue.Text
                    .Replace("LKR", "")
                    .Replace(",", "")
                    .Trim();

            if (!decimal.TryParse(
                expectedText,
                out decimal expectedCash))
            {
                expectedCash = 0;
            }

            decimal difference =
                actualCash - expectedCash;

            lblDifferenceValue.Text =
                $"LKR {difference:N2}";

            if (difference == 0)
            {
                lblDifferenceStatus.Text =
                    "BALANCED";
            }
            else if (difference > 0)
            {
                lblDifferenceStatus.Text =
                    "OVER";
            }
            else
            {
                lblDifferenceStatus.Text =
                    "SHORT";
            }
        }

        // ============================================
        // END DAY
        // ============================================

        private async void btnEndDay_Click(
            object sender,
            EventArgs e)
        {
            if (_currentSession == null)
                return;

            try
            {
                if (!decimal.TryParse(
                    txtActualCash.Text,
                    out decimal actualCash))
                {
                    MessageBox.Show(
                        "Please enter the actual cash amount.",
                        "Invalid Amount",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var confirm =
                    MessageBox.Show(
                        "Are you sure you want to close " +
                        "the current business day?\n\n" +
                        "After closing the day, new sales " +
                        "and purchases will require a new day.",
                        "Confirm Day End",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                btnEndDay.Enabled = false;

                await _daySessionService
                    .CloseDayAsync(
                        _currentSession.DaySessionId,
                        actualCash,
                        _userId);

                MessageBox.Show(
                    "Business day closed successfully.",
                    "Day Closed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnEndDay.Enabled = true;
            }
        }

        // ============================================
        // CANCEL
        // ============================================

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}