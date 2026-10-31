namespace HardwarePOS.UI.Forms
{
    partial class AddNewStockForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            label11 = new Label();
            numericQty = new NumericUpDown();
            textStockInNo = new TextBox();
            label10 = new Label();
            dTInvoiceDate = new DateTimePicker();
            cmbSupplier = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            numericTotal = new NumericUpDown();
            cmbProductName = new ComboBox();
            textUnit = new TextBox();
            dgvProducts = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            cmbProductCode = new ComboBox();
            numericSellingPrice = new NumericUpDown();
            numericCostPrice = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            textInvoceNumber = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSellingPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCostPrice).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitle.Location = new Point(40, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Stock";

            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(numericQty);
            groupBox1.Controls.Add(textStockInNo);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dTInvoiceDate);
            groupBox1.Controls.Add(cmbSupplier);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericTotal);
            groupBox1.Controls.Add(cmbProductName);
            groupBox1.Controls.Add(textUnit);
            groupBox1.Controls.Add(dgvProducts);
            groupBox1.Controls.Add(cmbProductCode);
            groupBox1.Controls.Add(numericSellingPrice);
            groupBox1.Controls.Add(numericCostPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textInvoceNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1478, 556);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(707, 463);
            label11.Name = "label11";
            label11.Size = new Size(36, 20);
            label11.TabIndex = 54;
            label11.Text = "Qty ";
            // 
            // numericQty
            // 
            numericQty.BorderStyle = BorderStyle.FixedSingle;
            numericQty.Font = new Font("Segoe UI", 12F);
            numericQty.Location = new Point(707, 498);
            numericQty.Name = "numericQty";
            numericQty.Size = new Size(120, 34);
            numericQty.TabIndex = 53;
            numericQty.ValueChanged += (s, e) => CalculateTotal();
            // 
            // textStockInNo
            // 
            textStockInNo.BorderStyle = BorderStyle.FixedSingle;
            textStockInNo.Font = new Font("Segoe UI", 12F);
            textStockInNo.Location = new Point(31, 55);
            textStockInNo.Name = "textStockInNo";
            textStockInNo.ReadOnly = true;
            textStockInNo.RightToLeft = RightToLeft.No;
            textStockInNo.Size = new Size(329, 34);
            textStockInNo.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 32);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 51;
            label10.Text = "Stock In No";
            // 
            // dTInvoiceDate
            // 
            dTInvoiceDate.Font = new Font("Segoe UI", 12F);
            dTInvoiceDate.Location = new Point(1095, 55);
            dTInvoiceDate.Name = "dTInvoiceDate";
            dTInvoiceDate.Size = new Size(337, 34);
            dTInvoiceDate.TabIndex = 25;
            // 
            // cmbSupplier
            // 
            cmbSupplier.Font = new Font("Segoe UI", 12F);
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(743, 55);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(320, 36);
            cmbSupplier.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1198, 463);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 49;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1024, 463);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 48;
            label8.Text = "Sellng Price";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(853, 463);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 47;
            label7.Text = "Cost Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 463);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 46;
            label6.Text = "Unit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(295, 463);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 45;
            label5.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 463);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 29;
            label4.Text = "Product Code";
            // 
            // numericTotal
            // 
            numericTotal.BorderStyle = BorderStyle.FixedSingle;
            numericTotal.Font = new Font("Segoe UI", 12F);
            numericTotal.Location = new Point(1198, 498);
            numericTotal.Name = "numericTotal";
            numericTotal.ReadOnly = true;
            numericTotal.Size = new Size(234, 34);
            numericTotal.TabIndex = 44;
            // 
            // cmbProductName
            // 
            cmbProductName.Font = new Font("Segoe UI", 12F);
            cmbProductName.FormattingEnabled = true;
            cmbProductName.Location = new Point(295, 497);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.Size = new Size(250, 36);
            cmbProductName.TabIndex = 43;
            // 
            // textUnit
            // 
            textUnit.BorderStyle = BorderStyle.FixedSingle;
            textUnit.Font = new Font("Segoe UI", 12F);
            textUnit.Location = new Point(576, 499);
            textUnit.Name = "textUnit";
            textUnit.ReadOnly = true;
            textUnit.RightToLeft = RightToLeft.No;
            textUnit.Size = new Size(105, 34);
            textUnit.TabIndex = 42;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 35, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.ColumnHeadersHeight = 50;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, Column1 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle4;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(31, 113);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 50;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1401, 331);
            dgvProducts.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Code ";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Product Name";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Category ";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Brand";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Qty ";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Cost ";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Sellng price ";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Total";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // cmbProductCode
            // 
            cmbProductCode.Font = new Font("Segoe UI", 12F);
            cmbProductCode.FormattingEnabled = true;
            cmbProductCode.Location = new Point(31, 497);
            cmbProductCode.Name = "cmbProductCode";
            cmbProductCode.Size = new Size(235, 36);
            cmbProductCode.TabIndex = 29;
            cmbProductCode.SelectedIndexChanged += cmbProductCode_SelectedIndexChanged;
            // 
            // numericSellingPrice
            // 
            numericSellingPrice.BorderStyle = BorderStyle.FixedSingle;
            numericSellingPrice.Font = new Font("Segoe UI", 12F);
            numericSellingPrice.Location = new Point(1024, 498);
            numericSellingPrice.Name = "numericSellingPrice";
            numericSellingPrice.Size = new Size(146, 34);
            numericSellingPrice.TabIndex = 27;
            // 
            // numericCostPrice
            // 
            numericCostPrice.BorderStyle = BorderStyle.FixedSingle;
            numericCostPrice.Font = new Font("Segoe UI", 12F);
            numericCostPrice.Location = new Point(853, 499);
            numericCostPrice.Name = "numericCostPrice";
            numericCostPrice.Size = new Size(143, 34);
            numericCostPrice.TabIndex = 26;
            numericCostPrice.ValueChanged += (s, e) => CalculateTotal();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1098, 32);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 4;
            label3.Text = " Invoice Date ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(743, 32);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Supplier     ";
            // 
            // textInvoceNumber
            // 
            textInvoceNumber.BorderStyle = BorderStyle.FixedSingle;
            textInvoceNumber.Font = new Font("Segoe UI", 12F);
            textInvoceNumber.Location = new Point(389, 55);
            textInvoceNumber.Name = "textInvoceNumber";
            textInvoceNumber.RightToLeft = RightToLeft.No;
            textInvoceNumber.Size = new Size(329, 34);
            textInvoceNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(389, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Invoice No";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(979, 676);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 45);
            btnSave.TabIndex = 25;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1358, 676);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 45);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1170, 676);
            button1.Name = "button1";
            button1.Size = new Size(160, 45);
            button1.TabIndex = 27;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // AddNewStockForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 765);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Name = "AddNewStockForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewStockForm";
            Load += AddNewStockForm1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSellingPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCostPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private GroupBox groupBox1;
        private ComboBox cmbProductCode;
        private NumericUpDown numericSellingPrice;
        private NumericUpDown numericCostPrice;
        private Label label3;
        private Label label2;
        private TextBox textInvoceNumber;
        private Label label1;
        private DataGridView dgvProducts;
        private NumericUpDown numericTotal;
        private ComboBox cmbProductName;
        private TextBox textUnit;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbSupplier;
        private TextBox textStockInNo;
        private Label label10;
        private DateTimePicker dTInvoiceDate;
        private Button btnSave;
        private Button btnCancel;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn Column1;
        private Button button1;
        private Label label11;
        private NumericUpDown numericQty;
    }
}