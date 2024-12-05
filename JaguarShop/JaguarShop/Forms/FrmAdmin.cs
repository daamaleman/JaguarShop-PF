using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using JaguarShop.Services;
using MetroFramework;

namespace JaguarShop.Forms
{
    public partial class FrmAdmin : MetroFramework.Forms.MetroForm
    {
        private readonly ProductServices _productServices;
        public FrmAdmin()
        {
            InitializeComponent();
            _productServices = new ProductServices();
        }

        private void BtnSaveProduct_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos
            string Name = TxtProductName.Text;
            string Description = RtbProductDescrip.Text;
            string price = NudProductPrice.Text;
            string color = string.Empty;

            if (CbxProductCBlack.Checked)
            {
                color = CbxProductCBlack.Text;
            }
            else if (CbxProductCWhite.Checked)
            {
                color = CbxProductCWhite.Text;
            }
            else if (CbxProductOtherColor.Checked)
            {
                color = CbxProductOtherColor.Text;
            }
            string stock = NudProductStock.Text;

            // Validar campos
            if (!_productServices.ValidateFields(Name, Description, float.Parse(price), color, int.Parse(stock), out string errorMessage))
            {
                MetroMessageBox.Show(this,
                    errorMessage,
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Crear el producto
            var product = _productServices.CreateProduct(Name, Description, float.Parse(price), color, int.Parse(stock));

            // Guardar el producto
            try
            {
                _productServices.SaveProduct(product);

                // Mostrar un mensaje de éxito
                MetroMessageBox.Show(this,
                    "Producto guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Redirigir a la pantalla principal
                FrmCatalog catalog = new FrmCatalog();
                catalog.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de excepción
                MetroMessageBox.Show(this,
                    $"Error al guardar el producto: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            ReadConfig();
        }
        private void ReadConfig()
        {
            AppConfigFile appConfigFile = new AppConfigFile();
            appConfigFile.LoadAppConfig();
            this.Theme = appConfigFile.Theme ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            // Regresar a la pantalla principal
            FrmCatalog catalog = new FrmCatalog();
            catalog.Show();
            this.Close();
        }
    }
}
