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
using JaguarShop.Forms;
using JaguarShop.Services;

namespace JaguarShop
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        public static string LoggedInUserId {get; set; }
        public FrmLogin()
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

            // Verificar si la contrasena es igual a la que esta en el archivo RegisterFiles de la carpeta Services

            // Codifica la contraseña ingresada para compararla con la almacenada.
            string encodedPassword = Convert.ToBase64String(Encoding.UTF8.GetBytes(TxtPassword.Text));
            string filePath = "users_JaguarShop.txt";
            bool loginSuccessful = false;

            // Verifica si el archivo de usuarios existe.
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("ID: "))
                    {
                        string currentUserId = lines[i].Substring(4).Trim(); // Extrae el ID del usuario.
                        string Cif = "";
                        string Password = "";

                        for (int j = i + 1; j < lines.Length && !lines[j].StartsWith("-------------------------------"); j++)
                        {
                            if (lines[j].StartsWith("Cif: "))
                                Cif = lines[j].Substring(5).Trim(); // Extrae el cif.
                            else if (lines[j].StartsWith("Contraseña: "))
                                Password = lines[j].Substring(12).Trim(); // Extrae la contraseña.
                        }

                        // Valida el correo y la contraseña.
                        if (Cif == TxtCif.Text.Trim() && Password == encodedPassword)
                        {
                            loginSuccessful = true;
                            LoggedInUserId = currentUserId; // Guarda el ID del usuario autenticado.
                            break;
                        }
                    }
                }
            }
            else
            {
                // Muestra un mensaje de error si no se encuentra el archivo.
                MetroFramework.MetroMessageBox.Show(this, "No se encontró el archivo de registro de usuarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Muestra un mensaje dependiendo del resultado de la validación.
            if (loginSuccessful)
            {
                MetroFramework.MetroMessageBox.Show(this, "Bienvenido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abre el formulario principal y cierra el formulario de login.
                new FrmCatalog().Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Correo o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            // Abrir el formulario de registro y cerrar el formulario de login
            FrmRegister register = new FrmRegister();
            register.Show();
            this.Hide();
        }
    }
}
