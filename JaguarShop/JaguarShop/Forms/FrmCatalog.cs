using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaguarShop.Models;
using JaguarShop.Services;

namespace JaguarShop.Forms
{
    public partial class FrmCatalog : MetroFramework.Forms.MetroForm
    {
        public FrmCatalog()
        {
            InitializeComponent();
            LoadDataGrid();
        }


        private void LoadDataGrid()
        {
            // Configurar el DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Definir las columnas
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre del Producto", DataPropertyName = "ProductName" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "Description" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "Price" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Colores", DataPropertyName = "Colors" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock", DataPropertyName = "Stock" });

            // Cargar los datos desde el archivo
            var products = LoadProductsFromFile("JaguarShopProducts.txt");
            dataGridView1.DataSource = new BindingList<Product>(products);
        }

        private List<Product> LoadProductsFromFile(string filePath)
        {
            var products = new List<Product>();
            var lines = File.ReadAllLines(filePath);
            Product product = null;

            foreach (var line in lines)
            {
                if (line.StartsWith("-------------------------------"))
                {
                    if (product != null && IsValidProduct(product))
                    {
                        products.Add(product);
                    }
                    product = new Product();
                }
                else if (line.StartsWith("ID del Producto:"))
                {
                    product.Id = int.Parse(line.Replace("ID del Producto:", "").Trim());
                }
                else if (line.StartsWith("Nombre del Producto:"))
                {
                    product.ProductName = line.Replace("Nombre del Producto:", "").Trim();
                }
                else if (line.StartsWith("Descripción:"))
                {
                    product.Description = line.Replace("Descripción:", "").Trim();
                }
                else if (line.StartsWith("Precio:"))
                {
                    product.Price = (float)decimal.Parse(line.Replace("Precio:", "").Trim());
                }
                else if (line.StartsWith("Colores:"))
                {
                    product.Colors = line.Replace("Colores:", "").Trim();
                }
                else if (line.StartsWith("Stock:"))
                {
                    product.Stock = int.Parse(line.Replace("Stock:", "").Trim());
                }
            }

            // Agregar el último producto si es válido
            if (product != null && IsValidProduct(product))
            {
                products.Add(product);
            }

            return products;
        }

        // Método auxiliar para validar que un producto está completamente inicializado
        private bool IsValidProduct(Product product)
        {
            return product != null &&
                   product.Id > 0 &&
                   !string.IsNullOrWhiteSpace(product.ProductName) &&
                   !string.IsNullOrWhiteSpace(product.Description) &&
                   product.Price > 0 &&
                   !string.IsNullOrWhiteSpace(product.Colors) &&
                   product.Stock > 0;
        }
        private void BtnBuyProduct_Click(object sender, EventArgs e)
        {
            FrmBuy frmBuy = new FrmBuy();
            frmBuy.Show();
            this.Close();
        }

        private void BtnBuyProduct2_Click(object sender, EventArgs e)
        {
            FrmBuy frmBuy = new FrmBuy();
            frmBuy.Show();
            this.Close();
        }

        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            FrmAboutUs frmAboutUs = new FrmAboutUs();
            frmAboutUs.Show();
            this.Close();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.Show();
            this.Close();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            // abrir el formulario de configuración
            FrmAppConfig frmConfig = new FrmAppConfig();
            frmConfig.Show();
            this.Close();
        }

        private void ReadConfig()
        {
            AppConfigFile appConfigFile = new AppConfigFile();
            appConfigFile.LoadAppConfig();
            this.Theme = appConfigFile.Theme ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;
        }

        private void FrmCatalog_Load(object sender, EventArgs e)
        {
            ReadConfig();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            // Salir de la aplicación con una advertencia
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "¿Está seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // abrir el formulario de configuración
            FrmAppConfig frmConfig = new FrmAppConfig();
            frmConfig.Show();
            this.Close();
        }
    }

}
