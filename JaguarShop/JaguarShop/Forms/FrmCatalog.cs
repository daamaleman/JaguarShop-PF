using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaguarShop.Forms
{
    public partial class FrmCatalog : MetroFramework.Forms.MetroForm
    {
        public FrmCatalog()
        {
            InitializeComponent();
        }

        private void BtnBuyProduct_Click(object sender, EventArgs e)
        {
            // Create a new instance of the FrmBuy form
            FrmBuy frmBuy = new FrmBuy();
            // Show the FrmBuy form
            frmBuy.Show();
            // Cerar el formulario actual
            this.Close();
        }

        private void BtnBuyProduct2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the FrmBuy form
            FrmBuy frmBuy = new FrmBuy();
            // Show the FrmBuy form
            frmBuy.Show();
            // Cerar el formulario actual
            this.Close();

        }

        private void BtnAboutUs_Click(object sender, EventArgs e)
        {
            // Create a new instance of the FrmAboutUs form
            FrmAboutUs frmAboutUs = new FrmAboutUs();
            // Show the FrmAboutUs form
            frmAboutUs.Show();
            // Cerar el formulario actual
            this.Close();
        }

    }
}
