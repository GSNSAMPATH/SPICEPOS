namespace HardwarePOS.UI.Forms
{
    partial class AddCategoryForm
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
            NameBox = new TextBox();
            DescriptionBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Segoe UI", 12F);
            NameBox.Location = new Point(41, 52);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(245, 34);
            NameBox.TabIndex = 0;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // DescriptionBox
            // 
            DescriptionBox.Font = new Font("Segoe UI", 12F);
            DescriptionBox.Location = new Point(345, 52);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(245, 34);
            DescriptionBox.TabIndex = 1;
            DescriptionBox.TextChanged += DescriptionBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 3;
            label1.Text = "CategoryName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 29);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(235, 135);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 45);
            btnSave.TabIndex = 22;
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
            btnCancel.Location = new Point(430, 135);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 45);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 213);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DescriptionBox);
            Controls.Add(NameBox);
            Name = "AddCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCategoryForm";
            Load += AddCategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private TextBox DescriptionBox;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}