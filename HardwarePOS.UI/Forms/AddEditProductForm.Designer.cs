namespace HardwarePOS.UI.Forms
{
    partial class AddEditProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblProductName;
        private Label lblCategory;
        private Label lblBrand;

        private Button btnSave;
        private Button btnCancel;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditProductForm));
            lblTitle = new Label();
            lblProductName = new Label();
            lblCategory = new Label();
            lblBrand = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            checkBoxActive = new CheckBox();
            button3 = new Button();
            button1 = new Button();
            cmbUnit = new ComboBox();
            label6 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            textDescriptoon = new TextBox();
            label3 = new Label();
            textProductName = new TextBox();
            label2 = new Label();
            textProductCode = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(49, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(286, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ADD PRODUCT";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblProductName
            // 
            lblProductName.Location = new Point(209, 215);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 23);
            lblProductName.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.Location = new Point(605, 228);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(100, 23);
            lblCategory.TabIndex = 3;
            // 
            // lblBrand
            // 
            lblBrand.Location = new Point(1005, 228);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(100, 23);
            lblBrand.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(901, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 45);
            btnSave.TabIndex = 21;
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
            btnCancel.Location = new Point(1081, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 45);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxActive);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cmbUnit);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textDescriptoon);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textProductName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textProductCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(58, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1183, 236);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Font = new Font("Segoe UI", 12F);
            checkBoxActive.Location = new Point(1040, 163);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(106, 32);
            checkBoxActive.TabIndex = 37;
            checkBoxActive.Text = "Is Active";
            checkBoxActive.UseVisualStyleBackColor = true;
            checkBoxActive.CheckedChanged += checkBoxActive_CheckedChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(46, 204, 113);
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button3.FlatAppearance.BorderSize = 2;
            button3.Location = new Point(691, 156);
            button3.Name = "button3";
            button3.Size = new Size(62, 40);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 204, 113);
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            button1.FlatAppearance.BorderSize = 2;
            button1.Location = new Point(298, 155);
            button1.Name = "button1";
            button1.Size = new Size(62, 40);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // cmbUnit
            // 
            cmbUnit.Font = new Font("Segoe UI", 12F);
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(424, 159);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(261, 36);
            cmbUnit.TabIndex = 11;
            cmbUnit.SelectedIndexChanged += cmbUnit_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 131);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 10;
            label6.Text = "Unit";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 12F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(31, 158);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(261, 36);
            cmbCategory.TabIndex = 7;
            cmbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 130);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 6;
            label4.Text = "Category";
            // 
            // textDescriptoon
            // 
            textDescriptoon.BorderStyle = BorderStyle.FixedSingle;
            textDescriptoon.Font = new Font("Segoe UI", 12F);
            textDescriptoon.Location = new Point(817, 70);
            textDescriptoon.Name = "textDescriptoon";
            textDescriptoon.Size = new Size(329, 34);
            textDescriptoon.TabIndex = 5;
            textDescriptoon.TextChanged += textDescriptoon_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(817, 47);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Description";
            label3.Click += label3_Click;
            // 
            // textProductName
            // 
            textProductName.BorderStyle = BorderStyle.FixedSingle;
            textProductName.Font = new Font("Segoe UI", 12F);
            textProductName.Location = new Point(424, 70);
            textProductName.Name = "textProductName";
            textProductName.Size = new Size(329, 34);
            textProductName.TabIndex = 3;
            textProductName.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 47);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 2;
            label2.Text = "Procduct Name";
            // 
            // textProductCode
            // 
            textProductCode.BorderStyle = BorderStyle.FixedSingle;
            textProductCode.Font = new Font("Segoe UI", 12F);
            textProductCode.Location = new Point(31, 70);
            textProductCode.Name = "textProductCode";
            textProductCode.RightToLeft = RightToLeft.No;
            textProductCode.Size = new Size(329, 34);
            textProductCode.TabIndex = 1;
            textProductCode.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "ProductCode ";
            label1.Click += label1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddEditProductForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1300, 479);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblProductName);
            Controls.Add(lblCategory);
            Controls.Add(lblBrand);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddEditProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            Load += AddEditProductForm_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void CreateLabel(
            Label label,
            string text,
            int x,
            int y)
        {
            label.Text = text;

            label.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            label.Location =
                new Point(x, y);

            label.AutoSize = true;
        }

        private void CreateTextBox(
            TextBox textBox,
            int x,
            int y)
        {
            textBox.Location =
                new Point(x, y);

            textBox.Size =
                new Size(350, 30);

            textBox.Font =
                new Font(
                    "Segoe UI",
                    10F);
        }

        private void CreateComboBox(
            ComboBox comboBox,
            int x,
            int y)
        {
            comboBox.Location =
                new Point(x, y);

            comboBox.Size =
                new Size(350, 30);

            comboBox.Font =
                new Font(
                    "Segoe UI",
                    10F);

            comboBox.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        private void CreateNumeric(
            NumericUpDown numeric,
            int x,
            int y)
        {
            numeric.Location =
                new Point(x, y);

            numeric.Size =
                new Size(350, 30);

            numeric.Font =
                new Font(
                    "Segoe UI",
                    10F);

            numeric.Maximum =
                999999999;

            numeric.DecimalPlaces = 2;
        }

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textProductName;
        private Label label2;
        private TextBox textProductCode;
        private ComboBox cmbUnit;
        private Label label6;
        private ComboBox cmbCategory;
        private Label label4;
        private Button button1;
        private Button button3;
        private CheckBox checkBoxActive;
        private ErrorProvider errorProvider1;
        private TextBox textDescriptoon;
        private Label label3;
    }
}