using System.Net.Mime;
using System.Xml.Linq;

namespace Baitap3
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
            // Clear any existing columns
            dgvProducts.Columns.Clear();

            // Add a column with custom header text "MaSP" but bind it to ProductID
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaSP",                     // The name of the column in the DataGridView
                HeaderText = "Mã SP",               // The header text displayed
                DataPropertyName = "ProductID",    // The property in the Product class to bind to
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Add more columns for other properties (Name, Quantity, etc.)
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Tên SP",
                DataPropertyName = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Số lượng",
                DataPropertyName = "Quantity",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Đơn giá",
                DataPropertyName = "Price",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Origin",
                HeaderText = "Xuất xứ",
                DataPropertyName = "Origin",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ExpirationDate",
                HeaderText = "Ngày hết hạn",
                DataPropertyName = "ExpirationDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

        }

        private void DisplayAllProducts()
        {
            // Ensure the data grid view is refreshed
            dgvProducts.DataSource = null;

            // Bind the list of products to the DataGridView
            dgvProducts.DataSource = products;
        }

        private void AddProduct()
        {
            Product product = new Product
            {
                ProductID = txtProductID.Text,
                Name = txtName.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Price = decimal.Parse(txtPrice.Text),
                Origin = txtOrigin.Text,
                ExpirationDate = dtpExpirationDate.Value
            };
            products.Add(product);
            MessageBox.Show("Product added successfully!");
            DisplayAllProducts();
        }
        private void CheckExpiredProducts()
        {
            var expiredProducts = products.Where(p => p.ExpirationDate < DateTime.Now).ToList();
            if (expiredProducts.Any())
            {
                MessageBox.Show("There are expired products in stock.");
            }
            else
            {
                MessageBox.Show("No expired products found.");
            }
        }

        private void FindMostExpensiveProduct()
        {
            var expensiveProduct = products.OrderByDescending(p => p.Price).FirstOrDefault();
            if (expensiveProduct != null)
            {
                MessageBox.Show($"Most expensive product: {expensiveProduct.Name} - {expensiveProduct.Price:C}");
            }
        }
        private void FindProductsFromJapan()
        {
            var japaneseProducts = products.Where(p => p.Origin == "Japan").ToList();
            dgvProducts.DataSource = japaneseProducts;
        }
        private void RemoveProductsByOrigin(string origin)
        {
            products.RemoveAll(p => p.Origin == origin);
            MessageBox.Show($"All products from {origin} have been removed.");
        }
        private void DisplayProductsInPriceRange(decimal minPrice, decimal maxPrice)
        {
            var filteredProducts = products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
            dgvProducts.DataSource = filteredProducts;
        }
        private void DeleteAllProducts()
        {
            products.Clear();
            MessageBox.Show("All products have been deleted.");
            DisplayAllProducts();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteAllProducts();
        }

        private void ExpensivePrice_Click(object sender, EventArgs e)
        {
            FindMostExpensiveProduct();
        }

        private void ProductFromJP_Click(object sender, EventArgs e)
        {
            FindProductsFromJapan();
        }

        private void ExpiredProducts_Click(object sender, EventArgs e)
        {
            CheckExpiredProducts();
        }

        private void btn_btnPriceInRange_Click(object sender, EventArgs e)
        {
            DisplayProductsInPriceRange(Convert.ToDecimal(this.txtMinPrice.Text), Convert.ToDecimal(this.txtMaxPrice));
        }

        private void btnDeleteExpiredProducts_Click(object sender, EventArgs e)
        {
            int removedCount = products.RemoveAll(p => p.ExpirationDate < DateTime.Now);

            if (removedCount > 0)
            {
                MessageBox.Show($"{removedCount} expired products have been deleted.");
            }
            else
            {
                MessageBox.Show("No expired products to delete.");
            }
            DisplayAllProducts();
        }

        private void btnCheckExpiredDate_Click(object sender, EventArgs e)
        {
            CheckExpiredProducts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btbDeleteFromOrigin_Click(object sender, EventArgs e)
        {
            RemoveProductsByOrigin(this.txtDeleteFromOrigin.Text);
            DisplayAllProducts();
        }
    }
}
