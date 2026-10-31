namespace HardwarePOS.UI.Forms
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel cardSales;
        private Panel cardProfit;
        private Panel cardProducts;

        private Label lblSalesTitle;
        private Label lblProfitTitle;
        private Label lblProductsTitle;

        private Label lblPurchasAmount;
        private Label lblsalseamount;
        private Label lblInventryvalue;

        protected override void Dispose(
            bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cardSales = new Panel();
            lblSalesTitle = new Label();
            lblPurchasAmount = new Label();
            cardProfit = new Panel();
            lblProfitTitle = new Label();
            lblsalseamount = new Label();
            cardProducts = new Panel();
            lblProductsTitle = new Label();
            lblInventryvalue = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label3 = new Label();
            lblProfit = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            cardSales.SuspendLayout();
            cardProfit.SuspendLayout();
            cardProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // cardSales
            // 
            cardSales.BackColor = Color.FromArgb(52, 152, 219);
            cardSales.Controls.Add(lblSalesTitle);
            cardSales.Controls.Add(lblPurchasAmount);
            cardSales.Location = new Point(61, 58);
            cardSales.Margin = new Padding(2);
            cardSales.Name = "cardSales";
            cardSales.Size = new Size(379, 138);
            cardSales.TabIndex = 0;
            // 
            // lblSalesTitle
            // 
            lblSalesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSalesTitle.ForeColor = Color.White;
            lblSalesTitle.Location = new Point(20, 20);
            lblSalesTitle.Margin = new Padding(2, 0, 2, 0);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(231, 22);
            lblSalesTitle.TabIndex = 0;
            lblSalesTitle.Text = "TODAY PURCHASE";
            // 
            // lblPurchasAmount
            // 
            lblPurchasAmount.AutoSize = true;
            lblPurchasAmount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPurchasAmount.ForeColor = Color.White;
            lblPurchasAmount.Location = new Point(20, 70);
            lblPurchasAmount.Margin = new Padding(0);
            lblPurchasAmount.Name = "lblPurchasAmount";
            lblPurchasAmount.Size = new Size(35, 41);
            lblPurchasAmount.TabIndex = 1;
            lblPurchasAmount.Text = "0\r\n";
            // 
            // cardProfit
            // 
            cardProfit.BackColor = Color.FromArgb(46, 204, 113);
            cardProfit.Controls.Add(lblProfitTitle);
            cardProfit.Controls.Add(lblsalseamount);
            cardProfit.Location = new Point(464, 58);
            cardProfit.Margin = new Padding(2);
            cardProfit.Name = "cardProfit";
            cardProfit.Size = new Size(392, 138);
            cardProfit.TabIndex = 1;
            // 
            // lblProfitTitle
            // 
            lblProfitTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProfitTitle.ForeColor = Color.White;
            lblProfitTitle.Location = new Point(20, 20);
            lblProfitTitle.Margin = new Padding(2, 0, 2, 0);
            lblProfitTitle.Name = "lblProfitTitle";
            lblProfitTitle.Size = new Size(196, 22);
            lblProfitTitle.TabIndex = 0;
            lblProfitTitle.Text = "TODAY SALES";
            // 
            // lblsalseamount
            // 
            lblsalseamount.AutoSize = true;
            lblsalseamount.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsalseamount.ForeColor = Color.White;
            lblsalseamount.Location = new Point(20, 70);
            lblsalseamount.Margin = new Padding(2, 0, 2, 0);
            lblsalseamount.Name = "lblsalseamount";
            lblsalseamount.Size = new Size(77, 41);
            lblsalseamount.TabIndex = 1;
            lblsalseamount.Text = "0.00";
            // 
            // cardProducts
            // 
            cardProducts.BackColor = Color.FromArgb(243, 156, 18);
            cardProducts.Controls.Add(lblProductsTitle);
            cardProducts.Controls.Add(lblInventryvalue);
            cardProducts.Location = new Point(1295, 58);
            cardProducts.Margin = new Padding(2);
            cardProducts.Name = "cardProducts";
            cardProducts.Size = new Size(391, 138);
            cardProducts.TabIndex = 2;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductsTitle.ForeColor = Color.White;
            lblProductsTitle.Location = new Point(20, 20);
            lblProductsTitle.Margin = new Padding(2, 0, 2, 0);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(262, 22);
            lblProductsTitle.TabIndex = 0;
            lblProductsTitle.Text = "TOTAL INVENTRY VALUE";
            // 
            // lblInventryvalue
            // 
            lblInventryvalue.AutoSize = true;
            lblInventryvalue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventryvalue.ForeColor = Color.White;
            lblInventryvalue.Location = new Point(20, 70);
            lblInventryvalue.Margin = new Padding(2, 0, 2, 0);
            lblInventryvalue.Name = "lblInventryvalue";
            lblInventryvalue.Size = new Size(35, 41);
            lblInventryvalue.TabIndex = 1;
            lblInventryvalue.Text = "0";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn2, Column1, Column2, Column3, Column4, dataGridViewTextBoxColumn5, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(61, 258);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1625, 608);
            dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 204, 113);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblProfit);
            panel2.Location = new Point(881, 58);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 138);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(20, 20);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(201, 22);
            label3.TabIndex = 0;
            label3.Text = "CASH BALANCE";
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfit.ForeColor = Color.White;
            lblProfit.Location = new Point(20, 70);
            lblProfit.Margin = new Padding(2, 0, 2, 0);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(77, 41);
            lblProfit.TabIndex = 1;
            lblProfit.Text = "0.00";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 32.08556F;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MaxInputLength = 32;
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 113.582886F;
            dataGridViewTextBoxColumn3.HeaderText = "Category Name";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 113.582886F;
            dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Gross Weight";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tare  weight";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "wet waite";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Net waite";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 113.582886F;
            dataGridViewTextBoxColumn5.HeaderText = "Average Price";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1735, 912);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(cardSales);
            Controls.Add(cardProfit);
            Controls.Add(cardProducts);
            Margin = new Padding(2);
            Name = "HomeForm";
            Text = "Dashboard";
            Load += HomeForm_Load_2;
            cardSales.ResumeLayout(false);
            cardSales.PerformLayout();
            cardProfit.ResumeLayout(false);
            cardProfit.PerformLayout();
            cardProducts.ResumeLayout(false);
            cardProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Panel panel1;
        private Label label1;
        private Label lblTotalStock;
        private Panel panel2;
        private Label label3;
        private Label lblProfit;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column5;
    }
}