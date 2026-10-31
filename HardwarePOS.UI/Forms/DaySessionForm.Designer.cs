namespace HardwarePOS.UI.Forms
{
    partial class DaySessionForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlHeader;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblDateTitle;
        private Label lblDate;

        private Label lblTimeTitle;
        private Label lblTime;

        private Label lblUserTitle;
        private Label lblUser;

        // Start Day
        private Panel pnlStartDay;
        private Label lblOpeningCashTitle;
        private TextBox txtOpeningCash;

        // End Day
        private Panel pnlEndDay;

        private Label lblOpeningCashLabel;
        private Label lblOpeningCashValue;

        private Label lblCashSalesLabel;
        private Label lblCashSalesValue;

        private Label lblPurchasePaymentsLabel;
        private Label lblPurchasePaymentsValue;

        private Label lblExpensesLabel;
        private Label lblCashInValue;

        private Label lblExpectedCashLabel;
        private Label lblExpectedCashValue;

        private Label lblActualCashLabel;
        private TextBox txtActualCash;

        private Label lblDifferenceLabel;
        private Label lblDifferenceValue;
        private Label lblDifferenceStatus;

        // Buttons
        private Button btnStartDay;
        private Button btnEndDay;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblDateTitle = new Label();
            lblDate = new Label();
            lblTimeTitle = new Label();
            lblTime = new Label();
            lblUserTitle = new Label();
            lblUser = new Label();
            pnlStartDay = new Panel();
            lblOpeningCashTitle = new Label();
            txtOpeningCash = new TextBox();
            pnlEndDay = new Panel();
            label1 = new Label();
            CashOutValue = new Label();
            lblOpeningCashLabel = new Label();
            lblOpeningCashValue = new Label();
            lblCashSalesLabel = new Label();
            lblCashSalesValue = new Label();
            lblPurchasePaymentsLabel = new Label();
            lblPurchasePaymentsValue = new Label();
            lblExpensesLabel = new Label();
            lblCashInValue = new Label();
            lblExpectedCashLabel = new Label();
            lblExpectedCashValue = new Label();
            lblActualCashLabel = new Label();
            txtActualCash = new TextBox();
            lblDifferenceLabel = new Label();
            lblDifferenceValue = new Label();
            lblDifferenceStatus = new Label();
            btnStartDay = new Button();
            btnEndDay = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            pnlStartDay.SuspendLayout();
            pnlEndDay.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(600, 103);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(255, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BUSINESS DAY";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Black;
            lblSubtitle.Location = new Point(35, 61);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(276, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage your current business day.";
            // 
            // lblDateTitle
            // 
            lblDateTitle.AutoSize = true;
            lblDateTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateTitle.Location = new Point(35, 125);
            lblDateTitle.Name = "lblDateTitle";
            lblDateTitle.Size = new Size(119, 23);
            lblDateTitle.TabIndex = 1;
            lblDateTitle.Text = "Business Date";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.Location = new Point(200, 125);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(17, 23);
            lblDate.TabIndex = 2;
            lblDate.Text = "-";
            // 
            // lblTimeTitle
            // 
            lblTimeTitle.AutoSize = true;
            lblTimeTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimeTitle.Location = new Point(35, 160);
            lblTimeTitle.Name = "lblTimeTitle";
            lblTimeTitle.Size = new Size(124, 23);
            lblTimeTitle.TabIndex = 3;
            lblTimeTitle.Text = "Opening Time";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10F);
            lblTime.Location = new Point(200, 160);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(17, 23);
            lblTime.TabIndex = 4;
            lblTime.Text = "-";
            // 
            // lblUserTitle
            // 
            lblUserTitle.AutoSize = true;
            lblUserTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserTitle.Location = new Point(35, 195);
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(98, 23);
            lblUserTitle.TabIndex = 5;
            lblUserTitle.Text = "Opened By";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10F);
            lblUser.Location = new Point(200, 195);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(17, 23);
            lblUser.TabIndex = 6;
            lblUser.Text = "-";
            // 
            // pnlStartDay
            // 
            pnlStartDay.BackColor = Color.White;
            pnlStartDay.Controls.Add(lblOpeningCashTitle);
            pnlStartDay.Controls.Add(txtOpeningCash);
            pnlStartDay.Location = new Point(30, 240);
            pnlStartDay.Name = "pnlStartDay";
            pnlStartDay.Size = new Size(539, 149);
            pnlStartDay.TabIndex = 7;
            // 
            // lblOpeningCashTitle
            // 
            lblOpeningCashTitle.AutoSize = true;
            lblOpeningCashTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOpeningCashTitle.Location = new Point(21, 20);
            lblOpeningCashTitle.Name = "lblOpeningCashTitle";
            lblOpeningCashTitle.Size = new Size(188, 25);
            lblOpeningCashTitle.TabIndex = 0;
            lblOpeningCashTitle.Text = "Opening Cash (LKR)";
            // 
            // txtOpeningCash
            // 
            txtOpeningCash.BorderStyle = BorderStyle.FixedSingle;
            txtOpeningCash.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtOpeningCash.Location = new Point(21, 60);
            txtOpeningCash.Name = "txtOpeningCash";
            txtOpeningCash.Size = new Size(500, 47);
            txtOpeningCash.TabIndex = 1;
            txtOpeningCash.Text = "0.00";
            txtOpeningCash.TextAlign = HorizontalAlignment.Right;
            // 
            // pnlEndDay
            // 
            pnlEndDay.BackColor = Color.White;
            pnlEndDay.Controls.Add(label1);
            pnlEndDay.Controls.Add(CashOutValue);
            pnlEndDay.Controls.Add(lblOpeningCashLabel);
            pnlEndDay.Controls.Add(lblOpeningCashValue);
            pnlEndDay.Controls.Add(lblCashSalesLabel);
            pnlEndDay.Controls.Add(lblCashSalesValue);
            pnlEndDay.Controls.Add(lblPurchasePaymentsLabel);
            pnlEndDay.Controls.Add(lblPurchasePaymentsValue);
            pnlEndDay.Controls.Add(lblExpensesLabel);
            pnlEndDay.Controls.Add(lblCashInValue);
            pnlEndDay.Controls.Add(lblExpectedCashLabel);
            pnlEndDay.Controls.Add(lblExpectedCashValue);
            pnlEndDay.Controls.Add(lblActualCashLabel);
            pnlEndDay.Controls.Add(txtActualCash);
            pnlEndDay.Controls.Add(lblDifferenceLabel);
            pnlEndDay.Controls.Add(lblDifferenceValue);
            pnlEndDay.Controls.Add(lblDifferenceStatus);
            pnlEndDay.Location = new Point(30, 240);
            pnlEndDay.Name = "pnlEndDay";
            pnlEndDay.Size = new Size(539, 422);
            pnlEndDay.TabIndex = 8;
            pnlEndDay.Visible = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(21, 206);
            label1.Name = "label1";
            label1.Size = new Size(219, 29);
            label1.TabIndex = 15;
            label1.Text = "Cash out";
            // 
            // CashOutValue
            // 
            CashOutValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CashOutValue.Location = new Point(299, 206);
            CashOutValue.Name = "CashOutValue";
            CashOutValue.Size = new Size(210, 29);
            CashOutValue.TabIndex = 16;
            CashOutValue.Text = "LKR 0.00";
            CashOutValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOpeningCashLabel
            // 
            lblOpeningCashLabel.Font = new Font("Segoe UI", 10F);
            lblOpeningCashLabel.Location = new Point(21, 20);
            lblOpeningCashLabel.Name = "lblOpeningCashLabel";
            lblOpeningCashLabel.Size = new Size(219, 29);
            lblOpeningCashLabel.TabIndex = 0;
            lblOpeningCashLabel.Text = "Opening Cash";
            // 
            // lblOpeningCashValue
            // 
            lblOpeningCashValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOpeningCashValue.Location = new Point(299, 20);
            lblOpeningCashValue.Name = "lblOpeningCashValue";
            lblOpeningCashValue.Size = new Size(210, 29);
            lblOpeningCashValue.TabIndex = 1;
            lblOpeningCashValue.Text = "LKR 0.00";
            lblOpeningCashValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCashSalesLabel
            // 
            lblCashSalesLabel.Font = new Font("Segoe UI", 10F);
            lblCashSalesLabel.Location = new Point(21, 65);
            lblCashSalesLabel.Name = "lblCashSalesLabel";
            lblCashSalesLabel.Size = new Size(219, 29);
            lblCashSalesLabel.TabIndex = 2;
            lblCashSalesLabel.Text = "Cash Sales (+)";
            // 
            // lblCashSalesValue
            // 
            lblCashSalesValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCashSalesValue.Location = new Point(299, 65);
            lblCashSalesValue.Name = "lblCashSalesValue";
            lblCashSalesValue.Size = new Size(210, 29);
            lblCashSalesValue.TabIndex = 3;
            lblCashSalesValue.Text = "LKR 0.00";
            lblCashSalesValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPurchasePaymentsLabel
            // 
            lblPurchasePaymentsLabel.Font = new Font("Segoe UI", 10F);
            lblPurchasePaymentsLabel.Location = new Point(21, 109);
            lblPurchasePaymentsLabel.Name = "lblPurchasePaymentsLabel";
            lblPurchasePaymentsLabel.Size = new Size(219, 29);
            lblPurchasePaymentsLabel.TabIndex = 4;
            lblPurchasePaymentsLabel.Text = "Purchase Payments (-)";
            // 
            // lblPurchasePaymentsValue
            // 
            lblPurchasePaymentsValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPurchasePaymentsValue.Location = new Point(299, 109);
            lblPurchasePaymentsValue.Name = "lblPurchasePaymentsValue";
            lblPurchasePaymentsValue.Size = new Size(210, 29);
            lblPurchasePaymentsValue.TabIndex = 5;
            lblPurchasePaymentsValue.Text = "LKR 0.00";
            lblPurchasePaymentsValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblExpensesLabel
            // 
            lblExpensesLabel.Font = new Font("Segoe UI", 10F);
            lblExpensesLabel.Location = new Point(21, 155);
            lblExpensesLabel.Name = "lblExpensesLabel";
            lblExpensesLabel.Size = new Size(219, 29);
            lblExpensesLabel.TabIndex = 6;
            lblExpensesLabel.Text = "Cash in";
            // 
            // lblCashInValue
            // 
            lblCashInValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCashInValue.Location = new Point(299, 155);
            lblCashInValue.Name = "lblCashInValue";
            lblCashInValue.Size = new Size(210, 29);
            lblCashInValue.TabIndex = 7;
            lblCashInValue.Text = "LKR 0.00";
            lblCashInValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblExpectedCashLabel
            // 
            lblExpectedCashLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblExpectedCashLabel.Location = new Point(21, 252);
            lblExpectedCashLabel.Name = "lblExpectedCashLabel";
            lblExpectedCashLabel.Size = new Size(219, 35);
            lblExpectedCashLabel.TabIndex = 8;
            lblExpectedCashLabel.Text = "Expected Cash";
            // 
            // lblExpectedCashValue
            // 
            lblExpectedCashValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblExpectedCashValue.Location = new Point(280, 252);
            lblExpectedCashValue.Name = "lblExpectedCashValue";
            lblExpectedCashValue.Size = new Size(230, 35);
            lblExpectedCashValue.TabIndex = 9;
            lblExpectedCashValue.Text = "LKR 0.00";
            lblExpectedCashValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblActualCashLabel
            // 
            lblActualCashLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActualCashLabel.Location = new Point(21, 310);
            lblActualCashLabel.Name = "lblActualCashLabel";
            lblActualCashLabel.Size = new Size(200, 29);
            lblActualCashLabel.TabIndex = 10;
            lblActualCashLabel.Text = "Actual Cash (LKR)";
            // 
            // txtActualCash
            // 
            txtActualCash.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtActualCash.Location = new Point(280, 306);
            txtActualCash.Name = "txtActualCash";
            txtActualCash.Size = new Size(230, 34);
            txtActualCash.TabIndex = 11;
            txtActualCash.TextAlign = HorizontalAlignment.Right;
            txtActualCash.TextChanged += txtActualCash_TextChanged;
            // 
            // lblDifferenceLabel
            // 
            lblDifferenceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDifferenceLabel.Location = new Point(21, 372);
            lblDifferenceLabel.Name = "lblDifferenceLabel";
            lblDifferenceLabel.Size = new Size(150, 29);
            lblDifferenceLabel.TabIndex = 12;
            lblDifferenceLabel.Text = "Difference";
            // 
            // lblDifferenceValue
            // 
            lblDifferenceValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDifferenceValue.Location = new Point(190, 372);
            lblDifferenceValue.Name = "lblDifferenceValue";
            lblDifferenceValue.Size = new Size(210, 29);
            lblDifferenceValue.TabIndex = 13;
            lblDifferenceValue.Text = "LKR 0.00";
            lblDifferenceValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDifferenceStatus
            // 
            lblDifferenceStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDifferenceStatus.Location = new Point(410, 372);
            lblDifferenceStatus.Name = "lblDifferenceStatus";
            lblDifferenceStatus.Size = new Size(101, 29);
            lblDifferenceStatus.TabIndex = 14;
            lblDifferenceStatus.Text = "BALANCE";
            lblDifferenceStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartDay
            // 
            btnStartDay.BackColor = Color.FromArgb(46, 204, 113);
            btnStartDay.FlatAppearance.BorderSize = 0;
            btnStartDay.FlatStyle = FlatStyle.Flat;
            btnStartDay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStartDay.ForeColor = Color.White;
            btnStartDay.Location = new Point(320, 420);
            btnStartDay.Name = "btnStartDay";
            btnStartDay.Size = new Size(250, 55);
            btnStartDay.TabIndex = 9;
            btnStartDay.Text = "START DAY";
            btnStartDay.UseVisualStyleBackColor = false;
            btnStartDay.Click += btnStartDay_Click;
            // 
            // btnEndDay
            // 
            btnEndDay.BackColor = Color.FromArgb(231, 76, 60);
            btnEndDay.FlatAppearance.BorderSize = 0;
            btnEndDay.FlatStyle = FlatStyle.Flat;
            btnEndDay.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEndDay.ForeColor = Color.White;
            btnEndDay.Location = new Point(319, 687);
            btnEndDay.Name = "btnEndDay";
            btnEndDay.Size = new Size(250, 51);
            btnEndDay.TabIndex = 10;
            btnEndDay.Text = "CLOSE DAY";
            btnEndDay.UseVisualStyleBackColor = false;
            btnEndDay.Visible = false;
            btnEndDay.Click += btnEndDay_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(52, 152, 219);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(30, 687);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 51);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // DaySessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(600, 775);
            Controls.Add(pnlHeader);
            Controls.Add(lblDateTitle);
            Controls.Add(lblDate);
            Controls.Add(lblTimeTitle);
            Controls.Add(lblTime);
            Controls.Add(lblUserTitle);
            Controls.Add(lblUser);
            Controls.Add(pnlEndDay);
            Controls.Add(btnStartDay);
            Controls.Add(btnEndDay);
            Controls.Add(btnCancel);
            Controls.Add(pnlStartDay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DaySessionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Business Day";
            Load += DaySessionForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlStartDay.ResumeLayout(false);
            pnlStartDay.PerformLayout();
            pnlEndDay.ResumeLayout(false);
            pnlEndDay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label CashOutValue;
    }
}