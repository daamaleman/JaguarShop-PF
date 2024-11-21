namespace JaguarShop
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblCif = new MetroFramework.Controls.MetroLabel();
            this.TxtCif = new MetroFramework.Controls.MetroTextBox();
            this.LblPassword = new MetroFramework.Controls.MetroLabel();
            this.TxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.LnRegister = new MetroFramework.Controls.MetroLink();
            this.LlbRegister = new MetroFramework.Controls.MetroLabel();
            this.CbxSeePw = new MetroFramework.Controls.MetroCheckBox();
            this.PbxLoginLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCif
            // 
            this.LblCif.AutoSize = true;
            this.LblCif.Location = new System.Drawing.Point(153, 334);
            this.LblCif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCif.Name = "LblCif";
            this.LblCif.Size = new System.Drawing.Size(29, 19);
            this.LblCif.TabIndex = 0;
            this.LblCif.Text = "Cif:";
            // 
            // TxtCif
            // 
            // 
            // 
            // 
            this.TxtCif.CustomButton.Image = null;
            this.TxtCif.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TxtCif.CustomButton.Name = "";
            this.TxtCif.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtCif.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCif.CustomButton.TabIndex = 1;
            this.TxtCif.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCif.CustomButton.UseSelectable = true;
            this.TxtCif.CustomButton.Visible = false;
            this.TxtCif.Lines = new string[0];
            this.TxtCif.Location = new System.Drawing.Point(190, 334);
            this.TxtCif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCif.MaxLength = 32767;
            this.TxtCif.Name = "TxtCif";
            this.TxtCif.PasswordChar = '\0';
            this.TxtCif.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCif.SelectedText = "";
            this.TxtCif.SelectionLength = 0;
            this.TxtCif.SelectionStart = 0;
            this.TxtCif.ShortcutsEnabled = true;
            this.TxtCif.Size = new System.Drawing.Size(219, 35);
            this.TxtCif.TabIndex = 1;
            this.TxtCif.UseSelectable = true;
            this.TxtCif.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCif.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(104, 422);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(78, 19);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Contraseña:";
            // 
            // TxtPassword
            // 
            // 
            // 
            // 
            this.TxtPassword.CustomButton.Image = null;
            this.TxtPassword.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TxtPassword.CustomButton.Name = "";
            this.TxtPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPassword.CustomButton.TabIndex = 1;
            this.TxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPassword.CustomButton.UseSelectable = true;
            this.TxtPassword.CustomButton.Visible = false;
            this.TxtPassword.Lines = new string[0];
            this.TxtPassword.Location = new System.Drawing.Point(190, 422);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.ShortcutsEnabled = true;
            this.TxtPassword.Size = new System.Drawing.Size(219, 35);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSelectable = true;
            this.TxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(179, 514);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(154, 60);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LnRegister
            // 
            this.LnRegister.Location = new System.Drawing.Point(262, 622);
            this.LnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LnRegister.Name = "LnRegister";
            this.LnRegister.Size = new System.Drawing.Size(96, 23);
            this.LnRegister.TabIndex = 5;
            this.LnRegister.Text = "Regístrate";
            this.LnRegister.UseSelectable = true;
            this.LnRegister.Click += new System.EventHandler(this.LnRegister_Click);
            // 
            // LlbRegister
            // 
            this.LlbRegister.AutoSize = true;
            this.LlbRegister.Location = new System.Drawing.Point(136, 622);
            this.LlbRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LlbRegister.Name = "LlbRegister";
            this.LlbRegister.Size = new System.Drawing.Size(118, 19);
            this.LlbRegister.TabIndex = 6;
            this.LlbRegister.Text = "¿No tienes cuenta?";
            // 
            // CbxSeePw
            // 
            this.CbxSeePw.AutoSize = true;
            this.CbxSeePw.Location = new System.Drawing.Point(434, 428);
            this.CbxSeePw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxSeePw.Name = "CbxSeePw";
            this.CbxSeePw.Size = new System.Drawing.Size(39, 15);
            this.CbxSeePw.TabIndex = 7;
            this.CbxSeePw.Text = "Ver";
            this.CbxSeePw.UseSelectable = true;
            this.CbxSeePw.CheckedChanged += new System.EventHandler(this.CbxSeePw_CheckedChanged);
            // 
            // PbxLoginLogo
            // 
            this.PbxLoginLogo.Image = global::JaguarShop.Properties.Resources.LogoJaguarShopBlack;
            this.PbxLoginLogo.Location = new System.Drawing.Point(117, 62);
            this.PbxLoginLogo.Name = "PbxLoginLogo";
            this.PbxLoginLogo.Size = new System.Drawing.Size(283, 243);
            this.PbxLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxLoginLogo.TabIndex = 16;
            this.PbxLoginLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 692);
            this.Controls.Add(this.PbxLoginLogo);
            this.Controls.Add(this.CbxSeePw);
            this.Controls.Add(this.LlbRegister);
            this.Controls.Add(this.LnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtCif);
            this.Controls.Add(this.LblCif);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Text = "Iniciar Sesion";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.PbxLoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblCif;
        private MetroFramework.Controls.MetroTextBox TxtCif;
        private MetroFramework.Controls.MetroLabel LblPassword;
        private MetroFramework.Controls.MetroTextBox TxtPassword;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private MetroFramework.Controls.MetroLink LnRegister;
        private MetroFramework.Controls.MetroLabel LlbRegister;
        private MetroFramework.Controls.MetroCheckBox CbxSeePw;
        private System.Windows.Forms.PictureBox PbxLoginLogo;
    }
}

