using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        // Declare UI components
        private Label lblTitle, lblUsername, lblPassword;
        private TextBox txtUsername, txtPassword;
        private Button btnLogin, btnExit;
        private Panel headerPanel;

        public Login()
        {
            InitializeComponent();
            CreateLoginScreen();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // This method will execute when the Login form loads.
        }

        private void CreateLoginScreen()
        {
            // Set Form properties
            this.Text = "HADOSHOP - Stok Yönetim Sistemi";
            this.Size = new Size(450, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = ColorTranslator.FromHtml("#F4F4F4"); // Açık Gri Arka Plan

            // Header Panel
            headerPanel = new Panel
            {
                Size = new Size(450, 70),
                Location = new Point(0, 0),
                BackColor = ColorTranslator.FromHtml("#1E3A8A") // Koyu Mavi (Kurumsal)
            };
            this.Controls.Add(headerPanel);

            // Title Label
            lblTitle = new Label
            {
                Text = "HADOSHOP GİRİŞ EKRANI",
                ForeColor = Color.White,
                Font = new Font("Arial", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(100, 20)
            };
            headerPanel.Controls.Add(lblTitle);

            // Username Label
            lblUsername = new Label
            {
                Text = "Kullanıcı Adı:",
                Location = new Point(50, 100),
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#333333") // Koyu Gri
            };
            this.Controls.Add(lblUsername);

            // Username TextBox
            txtUsername = new TextBox
            {
                Location = new Point(150, 100),
                Width = 220,
                Font = new Font("Arial", 11)
            };
            this.Controls.Add(txtUsername);

            // Password Label
            lblPassword = new Label
            {
                Text = "Şifre:",
                Location = new Point(50, 150),
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#333333") // Koyu Gri
            };
            this.Controls.Add(lblPassword);

            // Password TextBox
            txtPassword = new TextBox
            {
                Location = new Point(150, 150),
                Width = 220,
                Font = new Font("Arial", 11),
                PasswordChar = '*'
            };
            this.Controls.Add(txtPassword);

            // Login Button
            btnLogin = new Button
            {
                Text = "GİRİŞ YAP",
                Location = new Point(150, 210),
                Width = 100,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#FF8C00"), // Turuncu
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);

            // Exit Button
            btnExit = new Button
            {
                Text = "ÇIKIŞ",
                Location = new Point(270, 210),
                Width = 100,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#DC143C"), // Kırmızı
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Click += BtnExit_Click;
            this.Controls.Add(btnExit);
        }

        // Login Button Click Event (Login Form Kapanıyor, Dashboard Açılıyor)
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                MessageBox.Show("HADOSHOP Stok Yönetim Sistemine Hoş Geldiniz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Dashboard'u aç ve Login formunu tamamen kapat
                Dashboard dashboard = new Dashboard();
                this.Hide(); // Önce Login Formu Gizle
                dashboard.Show(); // Dashboard'u Aç

                // Login formu tamamen kapatılıyor (uygulama içinde kalıcı olmaz)
                dashboard.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Exit Button Click Event
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
