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
    public partial class FrmBuy : MetroFramework.Forms.MetroForm
    {
        public FrmBuy()
        {
            InitializeComponent();
        }

        // Hacer que cuando se le de a la X redireccione al FrmCatalog
        private void FrmBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Create a new instance of the FrmCatalog form
            FrmCatalog frmCatalog = new FrmCatalog();
            // Show the FrmCatalog form
            frmCatalog.Show();
        }
    }
}
