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
    public partial class FrmAdmin : MetroFramework.Forms.MetroForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void BtnSaveProduct_Click(object sender, EventArgs e)
        {
            // Volver al catalogo
            FrmCatalog frmCatalog = new FrmCatalog();
            frmCatalog.Show();
            this.Close();
        }
    }
}
