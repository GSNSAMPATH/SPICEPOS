namespace HardwarePOS.UI.Forms
{
    partial class SalesPosForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Currentdatepic = new DateTimePicker();
            groupBox2 = new GroupBox();
            txtCustomerName = new TextBox();
            txtTelephone = new TextBox();
            txtInvoiceNo = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            CmbProduct = new ComboBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtPrice = new NumericUpDown();
            txtWetWeight = new NumericUpDown();
            txtTareWeight = new NumericUpDown();
            txtGrossWeight = new NumericUpDown();
            button1 = new Button();
            btnBuy = new Button();
            btnCancel = new Button();
            dataGridView2 = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            label12 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtWetWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTareWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGrossWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // Currentdatepic
            // 
            Currentdatepic.CalendarForeColor = SystemColors.Highlight;
            Currentdatepic.CalendarTrailingForeColor = SystemColors.Highlight;
            Currentdatepic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Currentdatepic.Format = DateTimePickerFormat.Short;
            Currentdatepic.ImeMode = ImeMode.Disable;
            Currentdatepic.Location = new Point(37, 68);
            Currentdatepic.Name = "Currentdatepic";
            Currentdatepic.Size = new Size(271, 34);
            Currentdatepic.TabIndex = 48;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Currentdatepic);
            groupBox2.Controls.Add(txtCustomerName);
            groupBox2.Controls.Add(txtTelephone);
            groupBox2.Controls.Add(txtInvoiceNo);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(59, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1487, 127);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Font = new Font("Segoe UI", 12F);
            txtCustomerName.Location = new Point(1142, 68);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.RightToLeft = RightToLeft.No;
            txtCustomerName.Size = new Size(292, 34);
            txtCustomerName.TabIndex = 47;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // txtTelephone
            // 
            txtTelephone.BorderStyle = BorderStyle.FixedSingle;
            txtTelephone.Font = new Font("Segoe UI", 12F);
            txtTelephone.Location = new Point(766, 68);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.RightToLeft = RightToLeft.No;
            txtTelephone.Size = new Size(292, 34);
            txtTelephone.TabIndex = 46;
            txtTelephone.TextChanged += txtTelephone_TextChanged;
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.BorderStyle = BorderStyle.FixedSingle;
            txtInvoiceNo.Font = new Font("Segoe UI", 12F);
            txtInvoiceNo.Location = new Point(385, 68);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.ReadOnly = true;
            txtInvoiceNo.RightToLeft = RightToLeft.No;
            txtInvoiceNo.Size = new Size(292, 34);
            txtInvoiceNo.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(37, 36);
            label9.Name = "label9";
            label9.Size = new Size(46, 23);
            label9.TabIndex = 43;
            label9.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(385, 36);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 42;
            label5.Text = "Invoice Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(766, 36);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 40;
            label2.Text = "Telephone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1142, 36);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 38;
            label1.Text = "Customer Name";
            // 
            // CmbProduct
            // 
            CmbProduct.Font = new Font("Segoe UI", 12F);
            CmbProduct.FormattingEnabled = true;
            CmbProduct.Location = new Point(214, 125);
            CmbProduct.Name = "CmbProduct";
            CmbProduct.Size = new Size(260, 36);
            CmbProduct.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 129);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 43;
            label3.Text = "Catogory / Grade";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(213, 52);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(261, 36);
            cmbCategory.TabIndex = 42;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 55);
            label4.Name = "label4";
            label4.Size = new Size(86, 28);
            label4.TabIndex = 41;
            label4.Text = "Product ";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column12, Column2, Column13, Column3, Column9, Column14, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(59, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1487, 197);
            dataGridView1.TabIndex = 45;
            // 
            // Column1
            // 
            Column1.FillWeight = 162.5201F;
            Column1.HeaderText = "Product Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column12
            // 
            Column12.HeaderText = "ProductId";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Visible = false;
            // 
            // Column2
            // 
            Column2.FillWeight = 130.378738F;
            Column2.HeaderText = "Ctogory/grade";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column13
            // 
            Column13.HeaderText = "CategoryId";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Visible = false;
            // 
            // Column3
            // 
            Column3.FillWeight = 97.16343F;
            Column3.HeaderText = "Price";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column9
            // 
            Column9.FillWeight = 73.6633453F;
            Column9.HeaderText = "Unit";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column14
            // 
            Column14.HeaderText = "UnitId";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Visible = false;
            // 
            // Column4
            // 
            Column4.FillWeight = 88.5303345F;
            Column4.HeaderText = "Gross Weight";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 86.87493F;
            Column5.HeaderText = "Tare  weight";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.FillWeight = 85.41884F;
            Column6.HeaderText = "wet waite";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.FillWeight = 84.1379852F;
            Column7.HeaderText = "Net waite";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.FillWeight = 91.3124847F;
            Column8.HeaderText = "Total price";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(574, 129);
            label6.Name = "label6";
            label6.Size = new Size(54, 28);
            label6.TabIndex = 45;
            label6.Text = "Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(30, 197);
            label11.Name = "label11";
            label11.Size = new Size(129, 28);
            label11.TabIndex = 49;
            label11.Text = "Gross Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 269);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 52;
            label7.Text = "Tare Weight";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(521, 51);
            label8.Name = "label8";
            label8.Size = new Size(115, 28);
            label8.TabIndex = 54;
            label8.Text = "Wet Weight";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtWetWeight);
            groupBox1.Controls.Add(txtTareWeight);
            groupBox1.Controls.Add(txtGrossWeight);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(CmbProduct);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Location = new Point(59, 489);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(943, 367);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 12F);
            txtPrice.Location = new Point(667, 127);
            txtPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(237, 34);
            txtPrice.TabIndex = 58;
            // 
            // txtWetWeight
            // 
            txtWetWeight.DecimalPlaces = 2;
            txtWetWeight.Font = new Font("Segoe UI", 12F);
            txtWetWeight.Location = new Point(667, 49);
            txtWetWeight.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            txtWetWeight.Name = "txtWetWeight";
            txtWetWeight.Size = new Size(237, 34);
            txtWetWeight.TabIndex = 57;
            txtWetWeight.Click += txtWetWeight_Click;
            txtWetWeight.Enter += txtWetWeight_Click;
            // 
            // txtTareWeight
            // 
            txtTareWeight.DecimalPlaces = 2;
            txtTareWeight.Font = new Font("Segoe UI", 12F);
            txtTareWeight.Location = new Point(214, 268);
            txtTareWeight.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtTareWeight.Name = "txtTareWeight";
            txtTareWeight.Size = new Size(261, 34);
            txtTareWeight.TabIndex = 56;
            txtTareWeight.Click += txtTareWeight_Click;
            txtTareWeight.Enter += txtTareWeight_Click;
            // 
            // txtGrossWeight
            // 
            txtGrossWeight.DecimalPlaces = 2;
            txtGrossWeight.Font = new Font("Segoe UI", 12F);
            txtGrossWeight.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            txtGrossWeight.Location = new Point(214, 196);
            txtGrossWeight.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            txtGrossWeight.Name = "txtGrossWeight";
            txtGrossWeight.Size = new Size(261, 34);
            txtGrossWeight.TabIndex = 55;
            txtGrossWeight.Click += txtGrossWeight_Click;
            txtGrossWeight.Enter += txtGrossWeight_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(723, 256);
            button1.Name = "button1";
            button1.Size = new Size(181, 51);
            button1.TabIndex = 3;
            button1.Text = "+ Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(46, 204, 113);
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuy.ForeColor = Color.White;
            btnBuy.Location = new Point(1059, 882);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(181, 51);
            btnBuy.TabIndex = 55;
            btnBuy.TabStop = false;
            btnBuy.Text = "Sale";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1365, 882);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(181, 51);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column10, Column11 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Location = new Point(1059, 501);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(487, 355);
            dataGridView2.TabIndex = 56;
            // 
            // Column10
            // 
            Column10.HeaderText = "";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 215;
            // 
            // Column11
            // 
            Column11.HeaderText = "";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 200;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(59, 51);
            label12.Name = "label12";
            label12.Size = new Size(88, 38);
            label12.TabIndex = 58;
            label12.Text = "Sales";
            // 
            // SalesPosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 973);
            Controls.Add(label12);
            Controls.Add(dataGridView2);
            Controls.Add(btnCancel);
            Controls.Add(btnBuy);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "SalesPosForm";
            Text = "Sales Form";
            Load += SalesPosForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtWetWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTareWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGrossWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private ComboBox cmbCategory;
        private Label label4;
        private ComboBox CmbProduct;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox textBox8;
        private TextBox textBox2;
        private TextBox txtInvoiceNo;
        private DateTimePicker Currentdatepic;
        private GroupBox groupBox1;
        private Button button1;
        private Button btnBuy;
        private Button btnCancel;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private NumericUpDown txtWetWeight;
        private NumericUpDown txtTareWeight;
        private NumericUpDown txt;
        private NumericUpDown txtGrossWeight;
        private TextBox txtCustomerName;
        private TextBox txtTelephone;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label12;
        private NumericUpDown txtPrice;
    }
}