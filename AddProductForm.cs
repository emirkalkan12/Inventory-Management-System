using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
            CreateAddProductFormUI();
        }

        private void CreateAddProductFormUI()
        {
            // Form properties
            this.Text = "HADOSHOP - Ürün Ekle";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = ColorTranslator.FromHtml("#F4F4F4");

            // Title Label
            Label lblTitle = new Label
            {
                Text = "Ürün Ekle",
                ForeColor = ColorTranslator.FromHtml("#1E3A8A"), // Dark Blue
                Font = new Font("Arial", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 20)
            };
            this.Controls.Add(lblTitle);

            // Product Name Label
            Label lblProductName = new Label
            {
                Text = "Ürün Adı:",
                Location = new Point(20, 60),
                Font = new Font("Arial", 12, FontStyle.Regular)
            };
            this.Controls.Add(lblProductName);

            // Product Name TextBox
            TextBox txtProductName = new TextBox
            {
                Location = new Point(120, 60),
                Width = 240,
                Font = new Font("Arial", 12)
            };
            this.Controls.Add(txtProductName);

            // Category Label
            Label lblCategory = new Label
            {
                Text = "Kategori:",
                Location = new Point(20, 100),
                Font = new Font("Arial", 12, FontStyle.Regular)
            };
            this.Controls.Add(lblCategory);

            // Category TextBox
            TextBox txtCategory = new TextBox
            {
                Location = new Point(120, 100),
                Width = 240,
                Font = new Font("Arial", 12)
            };
            this.Controls.Add(txtCategory);

            // Price Label
            Label lblPrice = new Label
            {
                Text = "Fiyat:",
                Location = new Point(20, 140),
                Font = new Font("Arial", 12, FontStyle.Regular)
            };
            this.Controls.Add(lblPrice);

            // Price TextBox
            TextBox txtPrice = new TextBox
            {
                Location = new Point(120, 140),
                Width = 240,
                Font = new Font("Arial", 12)
            };
            this.Controls.Add(txtPrice);

            // Quantity Label
            Label lblQuantity = new Label
            {
                Text = "Miktar:",
                Location = new Point(20, 180),
                Font = new Font("Arial", 12, FontStyle.Regular)
            };
            this.Controls.Add(lblQuantity);

            // Quantity TextBox
            TextBox txtQuantity = new TextBox
            {
                Location = new Point(120, 180),
                Width = 240,
                Font = new Font("Arial", 12)
            };
            this.Controls.Add(txtQuantity);

            // Save Button
            Button btnSave = new Button
            {
                Text = "Kaydet",
                Location = new Point(120, 220),
                Width = 100,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#FF8C00"), // Orange
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnSave.Click += (sender, e) => SaveProduct(txtProductName.Text, txtCategory.Text, txtPrice.Text, txtQuantity.Text);
            this.Controls.Add(btnSave);

            // Cancel Button
            Button btnCancel = new Button
            {
                Text = "İptal",
                Location = new Point(240, 220),
                Width = 100,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#DC143C"), // Red
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnCancel.Click += (sender, e) => this.Close(); // Close the form without saving
            this.Controls.Add(btnCancel);
        }

        // Save Product Method
        private void SaveProduct(string productName, string category, string price, string quantity)
        {
            // Here you can save the product to a database or in-memory list
            MessageBox.Show($"Ürün Eklendi: {productName}\nKategori: {category}\nFiyat: {price}\nMiktar: {quantity}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Close the form after saving
        }
    }
}
