using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Dashboard : Form
    {
        private Panel headerPanel, sideMenuPanel;
        private Label lblTitle, lblUsername;
        private Button btnProducts, btnStock, btnReports, btnLogout;

        public Dashboard()
        {
            InitializeComponent();
            CreateDashboardUI();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // This method runs when the Dashboard form loads.
        }

        private void CreateDashboardUI()
        {
            // Form properties
            this.Text = "HADOSHOP - Ana Menü";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = ColorTranslator.FromHtml("#F4F4F4");

            // Header Panel (Top Bar)
            headerPanel = new Panel
            {
                Size = new Size(800, 60),
                Location = new Point(0, 0),
                BackColor = ColorTranslator.FromHtml("#1E3A8A") // Koyu Mavi (Kurumsal)
            };
            this.Controls.Add(headerPanel);

            // Title Label
            lblTitle = new Label
            {
                Text = "HADOSHOP STOK YÖNETİM SİSTEMİ",
                ForeColor = Color.White,
                Font = new Font("Arial", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 15)
            };
            headerPanel.Controls.Add(lblTitle);

            // Username Label (Display User)
            lblUsername = new Label
            {
                Text = "Hoş Geldin, Recep",
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(600, 20)
            };
            headerPanel.Controls.Add(lblUsername);

            // Side Menu Panel (Left Bar)
            sideMenuPanel = new Panel
            {
                Size = new Size(200, 440),
                Location = new Point(0, 60),
                BackColor = Color.White
            };
            this.Controls.Add(sideMenuPanel);

            // Products Button
            btnProducts = new Button
            {
                Text = "Ürünler",
                Size = new Size(180, 50),
                Location = new Point(10, 20),
                BackColor = ColorTranslator.FromHtml("#FF8C00"), // Turuncu
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnProducts.Click += BtnProducts_Click;
            btnProducts.FlatAppearance.BorderSize = 0;
            sideMenuPanel.Controls.Add(btnProducts);

            // Stock Button
            btnStock = new Button
            {
                Text = "Stok",
                Size = new Size(180, 50),
                Location = new Point(10, 80),
                BackColor = ColorTranslator.FromHtml("#008B8B"), // Teal
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnStock.Click += BtnStock_Click;
            btnStock.FlatAppearance.BorderSize = 0;
            sideMenuPanel.Controls.Add(btnStock);

            // Reports Button
            btnReports = new Button
            {
                Text = "Raporlar",
                Size = new Size(180, 50),
                Location = new Point(10, 140),
                BackColor = ColorTranslator.FromHtml("#4682B4"), // Çelik Mavisi
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnReports.Click += BtnReports_Click;
            btnReports.FlatAppearance.BorderSize = 0;
            sideMenuPanel.Controls.Add(btnReports);

            // Logout Button
            btnLogout = new Button
            {
                Text = "Çıkış Yap",
                Size = new Size(180, 50),
                Location = new Point(10, 360),
                BackColor = ColorTranslator.FromHtml("#DC143C"), // Kırmızı
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnLogout.Click += BtnLogout_Click;
            btnLogout.FlatAppearance.BorderSize = 0;
            sideMenuPanel.Controls.Add(btnLogout);
        }

        // Events for Buttons
        private void BtnProducts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürünler Sayfası Açılıyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stok Yönetimi Sayfası Açılıyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Raporlar Sayfası Açılıyor...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // Dashboard'u kapat ve giriş ekranına dön
        }
    }
}
