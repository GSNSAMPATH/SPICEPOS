namespace HardwarePOS.UI.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlSidebar;
        private Panel pnlTopbar;
        private Panel pnlContent;

        private Label lblTitle;
        private Label lblUsername;

        private Button btnDashboard;
        private Button btnProducts;
        private Button btnInventory;
        private Button btnPOS;
        private Button btnLogout;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            pnlSidebar = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnInventory = new Button();
            btnPOS = new Button();
            btnLogout = new Button();
            pnlTopbar = new Panel();
            lblTitle = new Label();
            lblUsername = new Label();
            pnlContent = new Panel();
            pnlSidebar.SuspendLayout();
            pnlTopbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(35, 35, 50);
            pnlSidebar.Controls.Add(button4);
            pnlSidebar.Controls.Add(button3);
            pnlSidebar.Controls.Add(button2);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnInventory);
            pnlSidebar.Controls.Add(btnPOS);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(192, 727);
            pnlSidebar.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(35, 35, 50);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(31, 402);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(161, 48);
            button4.TabIndex = 7;
            button4.Text = "Cancel Bill";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(35, 35, 50);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(31, 349);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(161, 48);
            button3.TabIndex = 6;
            button3.Text = "Chash in Out";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 35, 50);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(31, 454);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(161, 48);
            button2.TabIndex = 5;
            button2.Text = "Day End";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(35, 35, 50);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 296);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(161, 48);
            button1.TabIndex = 4;
            button1.Text = "Sale";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(35, 35, 50);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(31, 90);
            btnDashboard.Margin = new Padding(2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(161, 48);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.BackColor = Color.FromArgb(35, 35, 50);
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(31, 190);
            btnProducts.Margin = new Padding(2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(161, 48);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(35, 35, 50);
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(31, 243);
            btnInventory.Margin = new Padding(2);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(161, 48);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackColor = Color.FromArgb(35, 35, 50);
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPOS.ForeColor = Color.White;
            btnPOS.Location = new Point(31, 142);
            btnPOS.Margin = new Padding(2);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(161, 48);
            btnPOS.TabIndex = 2;
            btnPOS.Text = "Purchssing";
            btnPOS.TextAlign = ContentAlignment.MiddleLeft;
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 53, 69);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(-8, 671);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(202, 48);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlTopbar
            // 
            pnlTopbar.BackColor = Color.White;
            pnlTopbar.Controls.Add(lblTitle);
            pnlTopbar.Controls.Add(lblUsername);
            pnlTopbar.Dock = DockStyle.Top;
            pnlTopbar.Location = new Point(192, 0);
            pnlTopbar.Margin = new Padding(2);
            pnlTopbar.Name = "pnlTopbar";
            pnlTopbar.Size = new Size(768, 53);
            pnlTopbar.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(18, 8);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Spice POS System";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(678, 20);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(49, 19);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Admin";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 245, 245);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(192, 53);
            pnlContent.Margin = new Padding(2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(768, 674);
            pnlContent.TabIndex = 0;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(960, 727);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopbar);
            Controls.Add(pnlSidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += DashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlTopbar.ResumeLayout(false);
            pnlTopbar.PerformLayout();
            ResumeLayout(false);
        }

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
    }
}