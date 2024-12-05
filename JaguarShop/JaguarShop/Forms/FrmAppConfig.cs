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
    public partial class FrmAppConfig : MetroFramework.Forms.MetroForm
    {
        public FrmAppConfig()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            // Regresar al formulario anterior
            FrmCatalog frmCatalog = new FrmCatalog();
            frmCatalog.Show();
            this.Close();
        }

        private void CbxTheme_CheckedChanged(object sender, EventArgs e)
        {
            // Cambiar el tema de la aplicacion
            if (CbxTheme.Checked)
            {
                MetroFramework.MetroMessageBox.Show(this, "Tema Oscuro", "Tema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Theme = MetroFramework.MetroThemeStyle.Dark;
                SaveTheme();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Tema Claro", "Tema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Theme = MetroFramework.MetroThemeStyle.Light;
                SaveTheme();
            }
        }

        private void SaveTheme()
        {
            AppConfigFile appConfigFile = new AppConfigFile();
            appConfigFile.Theme = CbxTheme.Checked;
            appConfigFile.SaveAppConfig();
        }

        private void LoadTheme()
        {
            AppConfigFile appConfigFile = new AppConfigFile();
            appConfigFile.LoadAppConfig();
            CbxTheme.Checked = appConfigFile.Theme;
            this.Theme = appConfigFile.Theme ? MetroFramework.MetroThemeStyle.Dark : MetroFramework.MetroThemeStyle.Light;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveTheme();
            // volver al formulario catalogo
            FrmCatalog frmCatalog = new FrmCatalog();
            frmCatalog.Show();
            this.Close();
        }
    }
}
