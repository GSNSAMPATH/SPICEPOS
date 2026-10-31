namespace HardwarePOS.UI.Forms
{
    partial class AddBrandForm
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
            components = new System.ComponentModel.Container();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            NameBox = new TextBox();
            label2 = new Label();
            DescriptionBox = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(426, 134);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 45);
            btnCancel.TabIndex = 29;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(231, 134);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 45);
            btnSave.TabIndex = 28;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 26;
            label1.Text = "BrandName";
            label1.Click += label1_Click;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F);
            NameBox.Location = new Point(37, 51);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(245, 34);
            NameBox.TabIndex = 24;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 28);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 27;
            label2.Text = "BrandDescription";
            // 
            // DescriptionBox
            // 
            DescriptionBox.AcceptsTab = true;
            DescriptionBox.Enabled = false;
            DescriptionBox.Font = new Font("Segoe UI", 12F);
            DescriptionBox.Location = new Point(341, 51);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.ReadOnly = true;
            DescriptionBox.Size = new Size(245, 34);
            DescriptionBox.TabIndex = 25;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddBrandForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 218);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescriptionBox);
            Controls.Add(NameBox);
            Name = "AddBrandForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBrandForm";
            Load += AddBrandForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private TextBox NameBox;
        private Label label2;
        private TextBox DescriptionBox;
        private ErrorProvider errorProvider1;
    }
}