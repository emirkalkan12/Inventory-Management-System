using System;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            CreateProductManagementUI();
        }

        private void CreateProductManagementUI()
        {
            // Form properties
            this.Text = "HADOSHOP - Ürün Yönetimi";
            this.Size = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = ColorTranslator.FromHtml("#F4F4F4");

            // Title Label
            Label lblTitle = new Label
            {
                Text = "Ürün Yönetimi",
                ForeColor = ColorTranslator.FromHtml("#1E3A8A"), // Dark Blue
                Font = new Font("Arial", 16, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 20)
            };
            this.Controls.Add(lblTitle);

            // Ürünler Listesi (Tablo)
            DataGridView dgvProducts = new DataGridView
            {
                Location = new Point(20, 80),
                Size = new Size(740, 250),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            };

            // Ürün bilgileri için sütunlar
            dgvProducts.Columns.Add("ProductName", "Ürün Adı");
            dgvProducts.Columns.Add("ProductCategory", "Kategori");
            dgvProducts.Columns.Add("ProductPrice", "Fiyat");
            dgvProducts.Columns.Add("ProductDate", "Tarih");
            dgvProducts.Columns.Add("ProductQuantity", "Adet");
            dgvProducts.Columns.Add("ProductBrand", "Marka");

            // Dummy Data (Örnek ürün verileri)
            dgvProducts.Rows.Add("Ayakkabı", "Ayakkabılar", "200", DateTime.Now.ToString("dd/MM/yyyy"), "50", "Nike");
            dgvProducts.Rows.Add("Tişört", "Giyim", "100", DateTime.Now.ToString("dd/MM/yyyy"), "30", "Adidas");

            // DataGridView'i ekle
            this.Controls.Add(dgvProducts);

            // Ürün Ekleme Butonu
            Button btnAddProduct = new Button
            {
                Text = "Ürün Ekle",
                Location = new Point(650, 20),
                Width = 100,
                Height = 40,
                BackColor = ColorTranslator.FromHtml("#FF8C00"), // Turuncu
                ForeColor = Color.White,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat
            };
            btnAddProduct.Click += BtnAddProduct_Click;
            this.Controls.Add(btnAddProduct);
        }

        // Ürün Ekleme Butonuna Tıklama İşlevi
        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            // Ürün ekleme için bir formu aç
            AddProductForm addProductForm = new AddProductForm();
            this.Hide(); // Hide the Products form
            addProductForm.ShowDialog(); // Show the AddProductForm as dialog
            this.Show(); // Show the Products form again after closing AddProductForm
        }
    }
}
