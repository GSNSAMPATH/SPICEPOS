namespace HardwarePOS.UI.Forms
{
    partial class AddSuppliersForm
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
            btnCancel = new Button();
            btnSave = new Button();
            label2 = new Label();
            label1 = new Label();
            Phon_NumberBox = new TextBox();
            NameBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            AddressBox = new TextBox();
            EmailBox = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(414, 210);
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
            btnSave.Location = new Point(219, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 45);
            btnSave.TabIndex = 28;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 26);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 27;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 26;
            label1.Text = "SupplierName";
            // 
            // Phon_NumberBox
            // 
            Phon_NumberBox.Font = new Font("Segoe UI", 12F);
            Phon_NumberBox.Location = new Point(329, 49);
            Phon_NumberBox.Name = "Phon_NumberBox";
            Phon_NumberBox.Size = new Size(245, 34);
            Phon_NumberBox.TabIndex = 25;
            Phon_NumberBox.TextChanged += Phon_NumberBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F);
            NameBox.Location = new Point(25, 49);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(245, 34);
            NameBox.TabIndex = 24;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 108);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 33;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 108);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 32;
            label4.Text = "Email";
            // 
            // AddressBox
            // 
            AddressBox.Font = new Font("Segoe UI", 12F);
            AddressBox.Location = new Point(329, 131);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(245, 34);
            AddressBox.TabIndex = 31;
            AddressBox.TextChanged += AddressBox_TextChanged;
            // 
            // EmailBox
            // 
            EmailBox.Font = new Font("Segoe UI", 12F);
            EmailBox.Location = new Point(25, 131);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(245, 34);
            EmailBox.TabIndex = 30;
            EmailBox.TextChanged += EmailBox_TextChanged;
            // 
            // AddSuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 295);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(AddressBox);
            Controls.Add(EmailBox);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Phon_NumberBox);
            Controls.Add(NameBox);
            Name = "AddSuppliersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSuppliersForm";
            Load += AddSuppliersForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private TextBox Phon_NumberBox;
        private TextBox NameBox;
        private Label label3;
        private Label label4;
        private TextBox AddressBox;
        private TextBox EmailBox;
    }
}