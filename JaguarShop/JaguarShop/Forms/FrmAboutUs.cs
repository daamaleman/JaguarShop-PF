using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaguarShop.Services;

namespace JaguarShop.Forms
{
    public partial class FrmAboutUs : MetroFramework.Forms.MetroForm
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }

        // Hacer que se cierre cuando se haga click en la X del formulario
        private void FrmAboutUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Create a new instance of the FrmCatalog form
            FrmCatalog frmCatalog = new FrmCatalog();
            // Show the FrmCatalog form
            frmCatalog.Show();
        }

        private void FrmAboutUs_Load(object sender, EventArgs e)
        {
            ReadConfig();
        }

        private void ReadConfig()
        {
            AppConfigFile appConfigFile = new AppConfigFile();
            appConfigFile.LoadAppConfig();
            this.Theme = appConfigFile.Theme ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;
        }
    }
}
