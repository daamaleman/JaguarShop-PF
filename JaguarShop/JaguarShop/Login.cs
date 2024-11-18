using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JaguarShop.Forms;

namespace JaguarShop
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Validaciones
            // 1.Ninguno de los Textbox deben estar vacios 
            if(string.IsNullOrWhiteSpace(TxtCif.Text) || string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. El CIF debe tener 8 caracteres
            if (TxtCif.Text.Length != 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "El CIF debe tener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. El CIF debe ser un numero
            if (!int.TryParse(TxtCif.Text, out _))
            {
                MetroFramework.MetroMessageBox.Show(this, "El CIF debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. El CIF debe ser un numero positivo
            if (int.Parse(TxtCif.Text) < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "El CIF debe ser un numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. La contraseña debe tener al menos 8 caracteres
            if (TxtPassword.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de bienvenida
            MetroFramework.MetroMessageBox.Show(this, "Bienvenido", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos usando clear
            TxtCif.Clear();
            TxtPassword.Clear();
        }

        private void CbxSeePw_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar u ocultar la contraseña
            if (CbxSeePw.Checked)
            {
                TxtPassword.PasswordChar = '\0';
                CbxSeePw.Text = "Ocultar";
            }
            else
            {
                TxtPassword.PasswordChar = '*';
                CbxSeePw.Text = "Ver";
            }
        }

        private void LnRegister_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de registro
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
