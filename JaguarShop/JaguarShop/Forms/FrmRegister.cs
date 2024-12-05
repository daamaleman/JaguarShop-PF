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
    public partial class FrmRegister : MetroFramework.Forms.MetroForm
    {
        private readonly RegisterFiles _registerFiles;
        public FrmRegister()
        {
            InitializeComponent();
            _registerFiles = new RegisterFiles("users_JaguarShop.txt");
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // Validaciones
            // 1.Ninguno de los Textbox deben estar vacios
            if (string.IsNullOrWhiteSpace(TxtRegisterFullName.Text) || string.IsNullOrWhiteSpace(TxtRegisterEmail.Text) || string.IsNullOrWhiteSpace(TxtRegisterCif.Text) || string.IsNullOrWhiteSpace(TxtRegisterPassword.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor, llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. El email debe tener un formato valido
            if (!TxtRegisterEmail.Text.Contains("@") || !TxtRegisterEmail.Text.Contains("uamv") || !TxtRegisterEmail.Text.Contains(".edu") || !TxtRegisterEmail.Text.Contains(".ni"))
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor, ingrese un email institucional valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. La contraseña debe tener al menos 8 caracteres
            if (TxtRegisterPassword.Text.Length < 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "La contraseña debe tener al menos 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. El CIF debe tener 8 caracteres
            if (TxtRegisterCif.Text.Length != 8)
            {
                MetroFramework.MetroMessageBox.Show(this, "El CIF debe tener 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. El CIF debe ser un numero
            if (!int.TryParse(TxtRegisterCif.Text, out _))
            {
                MetroFramework.MetroMessageBox.Show(this, "El CIF debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 6. El CIF debe ser un numero positivo
            if (int.Parse(TxtRegisterCif.Text) < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "El CIF debe ser un numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 7. El CIF debe ser un numero entero
            if (double.Parse(TxtRegisterCif.Text) % 1 != 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "El CIF debe ser un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 8. Hacer que el combobox sea un campo obligatorio
            if (CmbRegisterRol.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor, seleccione un tipo de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 9. Validar que la contrasena coincida con el confirmar contrasena
            if (TxtRegisterPassword.Text != TxtRegisterVPassword.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las contrasenas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 10. Verificar si el combobox es diferente de Comprador o Administrador
            if (CmbRegisterRol.SelectedItem.ToString() != "Comprador" && CmbRegisterRol.SelectedItem.ToString() != "Administrador")
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor, seleccione un tipo de usuario valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 11. Verificar si se selecciono una opcion en el combobox
            if (CmbRegisterRol.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor, seleccione un tipo de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el email ya está registrado
            if (_registerFiles.IsEmailRegistered(TxtRegisterEmail.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "El email ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registrar el usuario
            _registerFiles.RegisterUser(TxtRegisterFullName.Text, TxtRegisterEmail.Text, TxtRegisterCif.Text, TxtRegisterPassword.Text);

            // Limpiar los campos
            TxtRegisterFullName.Clear();
            TxtRegisterEmail.Clear();
            TxtRegisterCif.Clear();
            TxtRegisterPassword.Clear();
            CmbRegisterRol.SelectedIndex = -1;

            // Volver al login cuando le den ok al mensaje del register
            MetroFramework.MetroMessageBox.Show(this, "Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        // Hacer que en el nombre no se puedan ingresar numeros y que salte una alerta
        private void TxtRegisterFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "No se permiten numeros en el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hacer que en el CIF solo se puedan ingresar numeros y que salte una alerta
        private void TxtRegisterCif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "El CIF no debe contener letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxSeePw_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar u ocultar la contraseña
            if (CbxSeePw.Checked)
            {
                TxtRegisterPassword.PasswordChar = '\0';
                CbxSeePw.Text = "Ocultar";
            }
            else
            {
                TxtRegisterPassword.PasswordChar = '*';
                CbxSeePw.Text = "Ver";
            }
        }

        private void CbxSeeVPw_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar u ocultar la contraseña
            if (CbxSeeVPw.Checked)
            {
                TxtRegisterVPassword.PasswordChar = '\0';
                CbxSeeVPw.Text = "Ocultar";
            }
            else
            {
                TxtRegisterVPassword.PasswordChar = '*';
                CbxSeeVPw.Text = "Ver";
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
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
