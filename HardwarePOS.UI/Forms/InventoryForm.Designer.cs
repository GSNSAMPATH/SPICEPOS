namespace HardwarePOS.UI.Forms
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Panel pnlTop;

        private Button btnStockIn;

        private Label lblProducts;
        private Label lblStockValue;
        private Label lblLowStock;
        private Label lblMovements;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            lblTitle = new Label();
            lblProducts = new Label();
            lblStockValue = new Label();
            lblLowStock = new Label();
            lblMovements = new Label();
            tabLedger = new TabPage();
            label8 = new Label();
            txtSearch3 = new TextBox();
            cmbCategory3 = new ComboBox();
            dateTimePicker5 = new DateTimePicker();
            dateTimePicker6 = new DateTimePicker();
            label7 = new Label();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn26 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn27 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn28 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn29 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn30 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn31 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn32 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn33 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn34 = new DataGridViewTextBoxColumn();
            tabStockOut = new TabPage();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker4 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
            txtSearch2 = new TextBox();
            cmbCategory2 = new ComboBox();
            tabStockIn = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            txtSearch1 = new TextBox();
            cmbCategory1 = new ComboBox();
            tabInventory = new TabControl();
            tabCurrentStock = new TabPage();
            label1 = new Label();
            btnRefresh = new Button();
            dgvProducts = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            pnlTop.SuspendLayout();
            tabLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabStockOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabStockIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabInventory.SuspendLayout();
            tabCurrentStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1415, 79);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(17, 24, 39);
            lblTitle.Location = new Point(25, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory";
            // 
            // lblProducts
            // 
            lblProducts.Location = new Point(0, 0);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(100, 123);
            lblProducts.TabIndex = 0;
            // 
            // lblStockValue
            // 
            lblStockValue.Location = new Point(0, 0);
            lblStockValue.Name = "lblStockValue";
            lblStockValue.Size = new Size(100, 23);
            lblStockValue.TabIndex = 0;
            // 
            // lblLowStock
            // 
            lblLowStock.Location = new Point(0, 0);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(100, 23);
            lblLowStock.TabIndex = 0;
            // 
            // lblMovements
            // 
            lblMovements.Location = new Point(0, 0);
            lblMovements.Name = "lblMovements";
            lblMovements.Size = new Size(100, 23);
            lblMovements.TabIndex = 0;
            // 
            // tabLedger
            // 
            tabLedger.Controls.Add(label8);
            tabLedger.Controls.Add(txtSearch3);
            tabLedger.Controls.Add(cmbCategory3);
            tabLedger.Controls.Add(dateTimePicker5);
            tabLedger.Controls.Add(dateTimePicker6);
            tabLedger.Controls.Add(label7);
            tabLedger.Controls.Add(dataGridView3);
            tabLedger.Location = new Point(4, 37);
            tabLedger.Name = "tabLedger";
            tabLedger.Size = new Size(1343, 624);
            tabLedger.TabIndex = 3;
            tabLedger.Text = "Inventory Ledger";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(367, 21);
            label8.Name = "label8";
            label8.Size = new Size(104, 28);
            label8.TabIndex = 23;
            label8.Text = "Category ";
            // 
            // txtSearch3
            // 
            txtSearch3.BorderStyle = BorderStyle.FixedSingle;
            txtSearch3.Font = new Font("Segoe UI", 12F);
            txtSearch3.Location = new Point(21, 19);
            txtSearch3.Name = "txtSearch3";
            txtSearch3.PlaceholderText = "Search product...";
            txtSearch3.Size = new Size(308, 34);
            txtSearch3.TabIndex = 21;
            txtSearch3.TextChanged += txtSearch3_TextChanged;
            // 
            // cmbCategory3
            // 
            cmbCategory3.Font = new Font("Segoe UI", 12F);
            cmbCategory3.Location = new Point(457, 19);
            cmbCategory3.Name = "cmbCategory3";
            cmbCategory3.Size = new Size(230, 36);
            cmbCategory3.TabIndex = 22;
            cmbCategory3.SelectedIndexChanged += cmbCategory3_SelectedIndexChanged;
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(1101, 19);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(221, 34);
            dateTimePicker5.TabIndex = 20;
            dateTimePicker5.ValueChanged += dateTimePicker5_ValueChanged;
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(840, 19);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(222, 34);
            dateTimePicker6.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(724, 22);
            label7.Name = "label7";
            label7.Size = new Size(122, 28);
            label7.TabIndex = 18;
            label7.Text = "Date Range";
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(35, 35, 50);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.ColumnHeadersHeight = 50;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn26, dataGridViewTextBoxColumn27, dataGridViewTextBoxColumn28, dataGridViewTextBoxColumn29, dataGridViewTextBoxColumn30, dataGridViewTextBoxColumn31, dataGridViewTextBoxColumn32, dataGridViewTextBoxColumn33, dataGridViewTextBoxColumn34 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.Location = new Point(21, 63);
            dataGridView3.MultiSelect = false;
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 50;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(1301, 542);
            dataGridView3.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn26
            // 
            dataGridViewTextBoxColumn26.HeaderText = "ReferenceNo";
            dataGridViewTextBoxColumn26.MinimumWidth = 6;
            dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            dataGridViewTextBoxColumn27.HeaderText = "Product Name";
            dataGridViewTextBoxColumn27.MinimumWidth = 6;
            dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn28
            // 
            dataGridViewTextBoxColumn28.HeaderText = "Category ";
            dataGridViewTextBoxColumn28.MinimumWidth = 6;
            dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            dataGridViewTextBoxColumn28.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn29
            // 
            dataGridViewTextBoxColumn29.HeaderText = "Unit";
            dataGridViewTextBoxColumn29.MinimumWidth = 6;
            dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            dataGridViewTextBoxColumn30.HeaderText = "Quantity";
            dataGridViewTextBoxColumn30.MinimumWidth = 6;
            dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            dataGridViewTextBoxColumn31.HeaderText = "Gross Weight";
            dataGridViewTextBoxColumn31.MinimumWidth = 6;
            dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            dataGridViewTextBoxColumn32.HeaderText = "Unit Price";
            dataGridViewTextBoxColumn32.MinimumWidth = 6;
            dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            dataGridViewTextBoxColumn33.HeaderText = "Total Amount";
            dataGridViewTextBoxColumn33.MinimumWidth = 6;
            dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            dataGridViewTextBoxColumn34.HeaderText = "Date";
            dataGridViewTextBoxColumn34.MinimumWidth = 6;
            dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // tabStockOut
            // 
            tabStockOut.Controls.Add(dateTimePicker3);
            tabStockOut.Controls.Add(dateTimePicker4);
            tabStockOut.Controls.Add(label5);
            tabStockOut.Controls.Add(label6);
            tabStockOut.Controls.Add(dataGridView2);
            tabStockOut.Controls.Add(txtSearch2);
            tabStockOut.Controls.Add(cmbCategory2);
            tabStockOut.Location = new Point(4, 37);
            tabStockOut.Name = "tabStockOut";
            tabStockOut.Size = new Size(1343, 624);
            tabStockOut.TabIndex = 2;
            tabStockOut.Text = "Stock Out";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(1101, 19);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(221, 34);
            dateTimePicker3.TabIndex = 20;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(840, 19);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(223, 34);
            dateTimePicker4.TabIndex = 19;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(724, 22);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 18;
            label5.Text = "Date Range";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(367, 21);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 14;
            label6.Text = "Category ";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(35, 35, 50);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeight = 50;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21, dataGridViewTextBoxColumn22, dataGridViewTextBoxColumn23, dataGridViewTextBoxColumn24, dataGridViewTextBoxColumn25 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(21, 63);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 50;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1301, 541);
            dataGridView2.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "ReferenceNo";
            dataGridViewTextBoxColumn17.MinimumWidth = 6;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Product Name";
            dataGridViewTextBoxColumn18.MinimumWidth = 6;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.HeaderText = "Category ";
            dataGridViewTextBoxColumn19.MinimumWidth = 6;
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.HeaderText = "Unit";
            dataGridViewTextBoxColumn20.MinimumWidth = 6;
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.HeaderText = "Quantity";
            dataGridViewTextBoxColumn21.MinimumWidth = 6;
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.HeaderText = "GrossWeight";
            dataGridViewTextBoxColumn22.MinimumWidth = 6;
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            dataGridViewTextBoxColumn23.HeaderText = "Unit Price";
            dataGridViewTextBoxColumn23.MinimumWidth = 6;
            dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            dataGridViewTextBoxColumn24.HeaderText = "Total Amount";
            dataGridViewTextBoxColumn24.MinimumWidth = 6;
            dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            dataGridViewTextBoxColumn25.HeaderText = "Date";
            dataGridViewTextBoxColumn25.MinimumWidth = 6;
            dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // txtSearch2
            // 
            txtSearch2.BorderStyle = BorderStyle.FixedSingle;
            txtSearch2.Font = new Font("Segoe UI", 12F);
            txtSearch2.Location = new Point(21, 19);
            txtSearch2.Name = "txtSearch2";
            txtSearch2.PlaceholderText = "Search product...";
            txtSearch2.Size = new Size(308, 34);
            txtSearch2.TabIndex = 9;
            txtSearch2.TextChanged += txtSearch2_TextChanged;
            // 
            // cmbCategory2
            // 
            cmbCategory2.Font = new Font("Segoe UI", 12F);
            cmbCategory2.Location = new Point(457, 19);
            cmbCategory2.Name = "cmbCategory2";
            cmbCategory2.Size = new Size(230, 36);
            cmbCategory2.TabIndex = 10;
            cmbCategory2.SelectedIndexChanged += cmbCategory2_SelectedIndexChanged;
            // 
            // tabStockIn
            // 
            tabStockIn.Controls.Add(dateTimePicker2);
            tabStockIn.Controls.Add(dateTimePicker1);
            tabStockIn.Controls.Add(label3);
            tabStockIn.Controls.Add(label4);
            tabStockIn.Controls.Add(dataGridView1);
            tabStockIn.Controls.Add(txtSearch1);
            tabStockIn.Controls.Add(cmbCategory1);
            tabStockIn.Location = new Point(4, 37);
            tabStockIn.Name = "tabStockIn";
            tabStockIn.Size = new Size(1343, 624);
            tabStockIn.TabIndex = 1;
            tabStockIn.Text = "Stock In";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(1101, 19);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(221, 34);
            dateTimePicker2.TabIndex = 17;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(840, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(222, 34);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(724, 22);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 15;
            label3.Text = "Date Range";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(367, 21);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 14;
            label4.Text = "Category ";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(35, 35, 50);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, Column4, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Arial", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(21, 63);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1301, 539);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ReferenceNo";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Product Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Category ";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Unit";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "GrossWeight";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Unit Price";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Total Amount";
            dataGridViewTextBoxColumn14.MinimumWidth = 6;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Date";
            dataGridViewTextBoxColumn15.MinimumWidth = 6;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // txtSearch1
            // 
            txtSearch1.BorderStyle = BorderStyle.FixedSingle;
            txtSearch1.Font = new Font("Segoe UI", 12F);
            txtSearch1.Location = new Point(21, 19);
            txtSearch1.Name = "txtSearch1";
            txtSearch1.PlaceholderText = "Search product...";
            txtSearch1.Size = new Size(308, 34);
            txtSearch1.TabIndex = 9;
            txtSearch1.TextChanged += txtSearch1_TextChanged;
            // 
            // cmbCategory1
            // 
            cmbCategory1.Font = new Font("Segoe UI", 12F);
            cmbCategory1.Location = new Point(457, 19);
            cmbCategory1.Name = "cmbCategory1";
            cmbCategory1.Size = new Size(230, 36);
            cmbCategory1.TabIndex = 10;
            cmbCategory1.SelectedIndexChanged += cmbCategory1_SelectedIndexChanged;
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(tabCurrentStock);
            tabInventory.Controls.Add(tabStockIn);
            tabInventory.Controls.Add(tabStockOut);
            tabInventory.Controls.Add(tabLedger);
            tabInventory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabInventory.Location = new Point(25, 108);
            tabInventory.Name = "tabInventory";
            tabInventory.SelectedIndex = 0;
            tabInventory.Size = new Size(1351, 665);
            tabInventory.TabIndex = 5;
            // 
            // tabCurrentStock
            // 
            tabCurrentStock.Controls.Add(label1);
            tabCurrentStock.Controls.Add(btnRefresh);
            tabCurrentStock.Controls.Add(dgvProducts);
            tabCurrentStock.Controls.Add(txtSearch);
            tabCurrentStock.Controls.Add(cmbCategory);
            tabCurrentStock.Location = new Point(4, 37);
            tabCurrentStock.Name = "tabCurrentStock";
            tabCurrentStock.Size = new Size(1343, 624);
            tabCurrentStock.TabIndex = 0;
            tabCurrentStock.Text = "Current Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 21);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 7;
            label1.Text = "Category ";
            label1.Click += label1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(52, 152, 219);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1469, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 40);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(35, 35, 50);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProducts.ColumnHeadersHeight = 50;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, Column2, Column1, Column3 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Arial", 12F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle8;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.Location = new Point(21, 63);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 50;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1301, 544);
            dgvProducts.TabIndex = 5;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
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
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Unit";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Current stock";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Average Price";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Value";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(21, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search product...";
            txtSearch.Size = new Size(308, 34);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged_2;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.Location = new Point(457, 19);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(230, 36);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged_1;
            // 
            // InventoryForm
            // 
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1415, 785);
            Controls.Add(pnlTop);
            Controls.Add(tabInventory);
            Name = "InventoryForm";
            Text = "Inventory";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            tabLedger.ResumeLayout(false);
            tabLedger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabStockOut.ResumeLayout(false);
            tabStockOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabStockIn.ResumeLayout(false);
            tabStockIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabInventory.ResumeLayout(false);
            tabCurrentStock.ResumeLayout(false);
            tabCurrentStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }


        private void CreateCard(
            Panel panel,
            Label valueLabel,
            string title,
            string value,
            int x,
            int y)
        {
            Label titleLabel =
                new Label();

            panel.BackColor =
                Color.White;

            panel.Location =
                new Point(x, y);

            panel.Size =
                new Size(380, 120);

            titleLabel.Text = title;

            titleLabel.Font =
                new Font(
                    "Segoe UI",
                    10F);

            titleLabel.ForeColor =
                Color.FromArgb(107, 114, 128);

            titleLabel.Location =
                new Point(20, 20);

            titleLabel.AutoSize = true;

            valueLabel.Text = value;

            valueLabel.Font =
                new Font(
                    "Segoe UI Semibold",
                    20F,
                    FontStyle.Bold);

            valueLabel.ForeColor =
                Color.FromArgb(17, 24, 39);

            valueLabel.Location =
                new Point(20, 50);

            valueLabel.AutoSize = true;

            panel.Controls.Add(titleLabel);

            panel.Controls.Add(valueLabel);
        }
        private TabPage tabLedger;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private TabPage tabStockOut;
        private Label label6;
        private DataGridView dataGridView2;
        private TextBox textBox2;
        private ComboBox cmbCategory2;
        private TabPage tabStockIn;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TabControl tabInventory;
        private TabPage tabCurrentStock;
        private Label label1;
        private Button btnRefresh;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox txtSearch;
        private ComboBox cmbCategory;
        private DataGridViewTextBoxColumn Column3;
        private DateTimePicker dateTimePicker5;
        private DateTimePicker dateTimePicker6;
        private Label label7;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private Label label8;
        private TextBox textBox3;
        private ComboBox cmbCategory3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private ComboBox cmbCategory1;
        private TextBox txtSearch3;
        private TextBox txtSearch2;
        private TextBox txtSearch1;
    }
}