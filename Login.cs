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

        private void Form1_Load(object sender, EventArgs e)
        {
            // This method will execute when the form loads.
        }

        private void CreateLoginScreen()
        {
            // Set Form properties
            this.Text = "HADOSHOP - Inventory System";
            this.Size = new Size(450, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = ColorTranslator.FromHtml("#F4F4F4"); // Light Gray Background

            // Header Panel
            headerPanel = new Panel
            {
                Size = new Size(450, 70),
                Location = new Point(0, 0),
                BackColor = ColorTranslator.FromHtml("#1E3A8A") // Dark Blue (Corporate)
            };
            this.Controls.Add(headerPanel);

            // Title Label
            lblTitle = new Label
            {
                Text = "HADOSHOP LOGIN",
                ForeColor = Color.White,
                Font = new Font("Arial", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(110, 20)
            };
            headerPanel.Controls.Add(lblTitle);

            // Username Label
            lblUsername = new Label
            {
                Text = "Username:",
                Location = new Point(50, 100),
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#333333") // Dark Gray
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
                Text = "Password:",
                Location = new Point(50, 150),
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#333333") // Dark Gray
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
                Text = "LOGIN",
                Location = new Point(150, 210),
                Width = 100,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#FF8C00"), // Orange
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
                Text = "EXIT",
                Location = new Point(270, 210),
                Width = 100,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#DC143C"), // Red
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Click += BtnExit_Click;
            this.Controls.Add(btnExit);
        }

        // Login Button Click Event
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "1234")
            {
                MessageBox.Show("Welcome to HADOSHOP!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // TODO: Open the main dashboard form here
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Exit Button Click Event
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
