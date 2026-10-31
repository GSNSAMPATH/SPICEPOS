namespace HardwarePOS.UI.Forms
{
    partial class AddUnitForm
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
            ShortNameBox = new TextBox();
            NameBox = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(231, 76, 60);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(420, 138);
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
            btnSave.Location = new Point(225, 138);
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
            label2.Location = new Point(335, 32);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 27;
            label2.Text = "ShortName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 26;
            label1.Text = "UnitName";
            // 
            // ShortNameBox
            // 
            ShortNameBox.Font = new Font("Segoe UI", 12F);
            ShortNameBox.Location = new Point(335, 55);
            ShortNameBox.Name = "ShortNameBox";
            ShortNameBox.Size = new Size(245, 34);
            ShortNameBox.TabIndex = 25;
            ShortNameBox.TextChanged += ShortNameBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F);
            NameBox.Location = new Point(31, 55);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(245, 34);
            NameBox.TabIndex = 24;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // AddUnitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 216);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ShortNameBox);
            Controls.Add(NameBox);
            Name = "AddUnitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUnitForm";
            Load += AddUnitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private Label label1;
        private TextBox ShortNameBox;
        private TextBox NameBox;
    }
}