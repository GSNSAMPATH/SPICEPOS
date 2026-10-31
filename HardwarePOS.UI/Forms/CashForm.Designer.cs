namespace HardwarePOS.UI.Forms
{
    partial class CashForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblDate;
        private Label lblCategory;
        private Label lblAmount;
        private Label lblReference;
        private Label lblRemarks;
        private Label lblBalance;

        private DateTimePicker dtTransactionDate;
        private ComboBox cmbCategory;
        private NumericUpDown numAmount;
        private TextBox txtReference;
        private RichTextBox txtRemarks;
        private TextBox txtCurrentBalance;

        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblBalance = new Label();
            lblDate = new Label();
            lblCategory = new Label();
            lblAmount = new Label();
            lblReference = new Label();
            lblRemarks = new Label();
            dtTransactionDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            numAmount = new NumericUpDown();
            txtReference = new TextBox();
            txtRemarks = new RichTextBox();
            txtCurrentBalance = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CASH IN";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(30, 80);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(213, 28);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "Current Cash Balance";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(30, 145);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(138, 23);
            lblDate.TabIndex = 3;
            lblDate.Text = "Transaction Date";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(30, 196);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 23);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(30, 244);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(72, 23);
            lblAmount.TabIndex = 7;
            lblAmount.Text = "Amount";
            // 
            // lblReference
            // 
            lblReference.AutoSize = true;
            lblReference.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReference.Location = new Point(30, 297);
            lblReference.Name = "lblReference";
            lblReference.Size = new Size(113, 23);
            lblReference.TabIndex = 9;
            lblReference.Text = "Reference No";
            // 
            // lblRemarks
            // 
            lblRemarks.AutoSize = true;
            lblRemarks.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemarks.Location = new Point(30, 344);
            lblRemarks.Name = "lblRemarks";
            lblRemarks.Size = new Size(74, 23);
            lblRemarks.TabIndex = 11;
            lblRemarks.Text = "Remarks";
            // 
            // dtTransactionDate
            // 
            dtTransactionDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtTransactionDate.Location = new Point(249, 135);
            dtTransactionDate.Name = "dtTransactionDate";
            dtTransactionDate.Size = new Size(300, 34);
            dtTransactionDate.TabIndex = 4;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.Location = new Point(249, 188);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(300, 36);
            cmbCategory.TabIndex = 6;
            // 
            // numAmount
            // 
            numAmount.DecimalPlaces = 2;
            numAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numAmount.Location = new Point(249, 237);
            numAmount.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numAmount.Name = "numAmount";
            numAmount.Size = new Size(300, 34);
            numAmount.TabIndex = 8;
            numAmount.ThousandsSeparator = true;
            // 
            // txtReference
            // 
            txtReference.BorderStyle = BorderStyle.FixedSingle;
            txtReference.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReference.Location = new Point(249, 290);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(300, 34);
            txtReference.TabIndex = 10;
            // 
            // txtRemarks
            // 
            txtRemarks.BorderStyle = BorderStyle.FixedSingle;
            txtRemarks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemarks.Location = new Point(249, 337);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(300, 80);
            txtRemarks.TabIndex = 12;
            txtRemarks.Text = "";
            // 
            // txtCurrentBalance
            // 
            txtCurrentBalance.BackColor = Color.FromArgb(245, 247, 250);
            txtCurrentBalance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCurrentBalance.ForeColor = SystemColors.Desktop;
            txtCurrentBalance.Location = new Point(249, 77);
            txtCurrentBalance.Name = "txtCurrentBalance";
            txtCurrentBalance.ReadOnly = true;
            txtCurrentBalance.Size = new Size(300, 34);
            txtCurrentBalance.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(249, 448);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 45);
            btnSave.TabIndex = 13;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(409, 448);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 45);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // CashForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(591, 536);
            Controls.Add(lblTitle);
            Controls.Add(lblBalance);
            Controls.Add(txtCurrentBalance);
            Controls.Add(lblDate);
            Controls.Add(dtTransactionDate);
            Controls.Add(lblCategory);
            Controls.Add(cmbCategory);
            Controls.Add(lblAmount);
            Controls.Add(numAmount);
            Controls.Add(lblReference);
            Controls.Add(txtReference);
            Controls.Add(lblRemarks);
            Controls.Add(txtRemarks);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cash Transaction";
            ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}