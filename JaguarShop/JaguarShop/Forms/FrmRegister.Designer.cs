namespace JaguarShop.Forms
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblRegisterFullName = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterFullName = new MetroFramework.Controls.MetroTextBox();
            this.LblRegisterEmail = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterEmail = new MetroFramework.Controls.MetroTextBox();
            this.LblRegisterCif = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterCif = new MetroFramework.Controls.MetroTextBox();
            this.LblRegisterPassword = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterPassword = new MetroFramework.Controls.MetroTextBox();
            this.LblRegisterRol = new MetroFramework.Controls.MetroLabel();
            this.CmbRegisterRol = new MetroFramework.Controls.MetroComboBox();
            this.BtnRegister = new MetroFramework.Controls.MetroButton();
            this.LblRegisterVPassword = new MetroFramework.Controls.MetroLabel();
            this.TxtRegisterVPassword = new MetroFramework.Controls.MetroTextBox();
            this.CbxSeePw = new MetroFramework.Controls.MetroCheckBox();
            this.CbxSeeVPw = new MetroFramework.Controls.MetroCheckBox();
            this.PbxRegisterLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxRegisterLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegisterFullName
            // 
            this.LblRegisterFullName.AutoSize = true;
            this.LblRegisterFullName.Location = new System.Drawing.Point(122, 318);
            this.LblRegisterFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegisterFullName.Name = "LblRegisterFullName";
            this.LblRegisterFullName.Size = new System.Drawing.Size(128, 20);
            this.LblRegisterFullName.TabIndex = 0;
            this.LblRegisterFullName.Text = "Nombre Completo:";
            // 
            // TxtRegisterFullName
            // 
            // 
            // 
            // 
            this.TxtRegisterFullName.CustomButton.Image = null;
            this.TxtRegisterFullName.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.TxtRegisterFullName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterFullName.CustomButton.Name = "";
            this.TxtRegisterFullName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtRegisterFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterFullName.CustomButton.TabIndex = 1;
            this.TxtRegisterFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterFullName.CustomButton.UseSelectable = true;
            this.TxtRegisterFullName.CustomButton.Visible = false;
            this.TxtRegisterFullName.Lines = new string[0];
            this.TxtRegisterFullName.Location = new System.Drawing.Point(272, 318);
            this.TxtRegisterFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterFullName.MaxLength = 32767;
            this.TxtRegisterFullName.Name = "TxtRegisterFullName";
            this.TxtRegisterFullName.PasswordChar = '\0';
            this.TxtRegisterFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterFullName.SelectedText = "";
            this.TxtRegisterFullName.SelectionLength = 0;
            this.TxtRegisterFullName.SelectionStart = 0;
            this.TxtRegisterFullName.ShortcutsEnabled = true;
            this.TxtRegisterFullName.Size = new System.Drawing.Size(268, 35);
            this.TxtRegisterFullName.TabIndex = 1;
            this.TxtRegisterFullName.UseSelectable = true;
            this.TxtRegisterFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtRegisterFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRegisterFullName_KeyPress);
            // 
            // LblRegisterEmail
            // 
            this.LblRegisterEmail.AutoSize = true;
            this.LblRegisterEmail.Location = new System.Drawing.Point(122, 394);
            this.LblRegisterEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegisterEmail.Name = "LblRegisterEmail";
            this.LblRegisterEmail.Size = new System.Drawing.Size(131, 20);
            this.LblRegisterEmail.TabIndex = 2;
            this.LblRegisterEmail.Text = "Correo Institucional:";
            // 
            // TxtRegisterEmail
            // 
            // 
            // 
            // 
            this.TxtRegisterEmail.CustomButton.Image = null;
            this.TxtRegisterEmail.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.TxtRegisterEmail.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterEmail.CustomButton.Name = "";
            this.TxtRegisterEmail.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtRegisterEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterEmail.CustomButton.TabIndex = 1;
            this.TxtRegisterEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterEmail.CustomButton.UseSelectable = true;
            this.TxtRegisterEmail.CustomButton.Visible = false;
            this.TxtRegisterEmail.Lines = new string[0];
            this.TxtRegisterEmail.Location = new System.Drawing.Point(272, 394);
            this.TxtRegisterEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterEmail.MaxLength = 32767;
            this.TxtRegisterEmail.Name = "TxtRegisterEmail";
            this.TxtRegisterEmail.PasswordChar = '\0';
            this.TxtRegisterEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterEmail.SelectedText = "";
            this.TxtRegisterEmail.SelectionLength = 0;
            this.TxtRegisterEmail.SelectionStart = 0;
            this.TxtRegisterEmail.ShortcutsEnabled = true;
            this.TxtRegisterEmail.Size = new System.Drawing.Size(268, 35);
            this.TxtRegisterEmail.TabIndex = 3;
            this.TxtRegisterEmail.UseSelectable = true;
            this.TxtRegisterEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblRegisterCif
            // 
            this.LblRegisterCif.AutoSize = true;
            this.LblRegisterCif.Location = new System.Drawing.Point(219, 466);
            this.LblRegisterCif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegisterCif.Name = "LblRegisterCif";
            this.LblRegisterCif.Size = new System.Drawing.Size(29, 20);
            this.LblRegisterCif.TabIndex = 4;
            this.LblRegisterCif.Text = "Cif:";
            // 
            // TxtRegisterCif
            // 
            // 
            // 
            // 
            this.TxtRegisterCif.CustomButton.Image = null;
            this.TxtRegisterCif.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.TxtRegisterCif.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterCif.CustomButton.Name = "";
            this.TxtRegisterCif.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtRegisterCif.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterCif.CustomButton.TabIndex = 1;
            this.TxtRegisterCif.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterCif.CustomButton.UseSelectable = true;
            this.TxtRegisterCif.CustomButton.Visible = false;
            this.TxtRegisterCif.Lines = new string[0];
            this.TxtRegisterCif.Location = new System.Drawing.Point(272, 466);
            this.TxtRegisterCif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterCif.MaxLength = 32767;
            this.TxtRegisterCif.Name = "TxtRegisterCif";
            this.TxtRegisterCif.PasswordChar = '\0';
            this.TxtRegisterCif.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterCif.SelectedText = "";
            this.TxtRegisterCif.SelectionLength = 0;
            this.TxtRegisterCif.SelectionStart = 0;
            this.TxtRegisterCif.ShortcutsEnabled = true;
            this.TxtRegisterCif.Size = new System.Drawing.Size(268, 35);
            this.TxtRegisterCif.TabIndex = 5;
            this.TxtRegisterCif.UseSelectable = true;
            this.TxtRegisterCif.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterCif.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtRegisterCif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRegisterCif_KeyPress);
            // 
            // LblRegisterPassword
            // 
            this.LblRegisterPassword.AutoSize = true;
            this.LblRegisterPassword.Location = new System.Drawing.Point(169, 528);
            this.LblRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegisterPassword.Name = "LblRegisterPassword";
            this.LblRegisterPassword.Size = new System.Drawing.Size(82, 20);
            this.LblRegisterPassword.TabIndex = 6;
            this.LblRegisterPassword.Text = "Contraseña:";
            // 
            // TxtRegisterPassword
            // 
            // 
            // 
            // 
            this.TxtRegisterPassword.CustomButton.Image = null;
            this.TxtRegisterPassword.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.TxtRegisterPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterPassword.CustomButton.Name = "";
            this.TxtRegisterPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtRegisterPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterPassword.CustomButton.TabIndex = 1;
            this.TxtRegisterPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterPassword.CustomButton.UseSelectable = true;
            this.TxtRegisterPassword.CustomButton.Visible = false;
            this.TxtRegisterPassword.Lines = new string[0];
            this.TxtRegisterPassword.Location = new System.Drawing.Point(272, 528);
            this.TxtRegisterPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterPassword.MaxLength = 32767;
            this.TxtRegisterPassword.Name = "TxtRegisterPassword";
            this.TxtRegisterPassword.PasswordChar = '*';
            this.TxtRegisterPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterPassword.SelectedText = "";
            this.TxtRegisterPassword.SelectionLength = 0;
            this.TxtRegisterPassword.SelectionStart = 0;
            this.TxtRegisterPassword.ShortcutsEnabled = true;
            this.TxtRegisterPassword.Size = new System.Drawing.Size(268, 35);
            this.TxtRegisterPassword.TabIndex = 7;
            this.TxtRegisterPassword.UseSelectable = true;
            this.TxtRegisterPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblRegisterRol
            // 
            this.LblRegisterRol.AutoSize = true;
            this.LblRegisterRol.Location = new System.Drawing.Point(216, 649);
            this.LblRegisterRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegisterRol.Name = "LblRegisterRol";
            this.LblRegisterRol.Size = new System.Drawing.Size(31, 20);
            this.LblRegisterRol.TabIndex = 8;
            this.LblRegisterRol.Text = "Rol:";
            // 
            // CmbRegisterRol
            // 
            this.CmbRegisterRol.FormattingEnabled = true;
            this.CmbRegisterRol.ItemHeight = 24;
            this.CmbRegisterRol.Items.AddRange(new object[] {
            "Comprador",
            "Administrador"});
            this.CmbRegisterRol.Location = new System.Drawing.Point(272, 649);
            this.CmbRegisterRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbRegisterRol.Name = "CmbRegisterRol";
            this.CmbRegisterRol.Size = new System.Drawing.Size(266, 30);
            this.CmbRegisterRol.TabIndex = 9;
            this.CmbRegisterRol.UseSelectable = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(257, 704);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(141, 65);
            this.BtnRegister.TabIndex = 10;
            this.BtnRegister.Text = "Registrarse";
            this.BtnRegister.UseSelectable = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // LblRegisterVPassword
            // 
            this.LblRegisterVPassword.AutoSize = true;
            this.LblRegisterVPassword.Location = new System.Drawing.Point(105, 584);
            this.LblRegisterVPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRegisterVPassword.Name = "LblRegisterVPassword";
            this.LblRegisterVPassword.Size = new System.Drawing.Size(147, 20);
            this.LblRegisterVPassword.TabIndex = 11;
            this.LblRegisterVPassword.Text = "Confirmar Contraseña:";
            // 
            // TxtRegisterVPassword
            // 
            // 
            // 
            // 
            this.TxtRegisterVPassword.CustomButton.Image = null;
            this.TxtRegisterVPassword.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.TxtRegisterVPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterVPassword.CustomButton.Name = "";
            this.TxtRegisterVPassword.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.TxtRegisterVPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRegisterVPassword.CustomButton.TabIndex = 1;
            this.TxtRegisterVPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtRegisterVPassword.CustomButton.UseSelectable = true;
            this.TxtRegisterVPassword.CustomButton.Visible = false;
            this.TxtRegisterVPassword.Lines = new string[0];
            this.TxtRegisterVPassword.Location = new System.Drawing.Point(270, 584);
            this.TxtRegisterVPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRegisterVPassword.MaxLength = 32767;
            this.TxtRegisterVPassword.Name = "TxtRegisterVPassword";
            this.TxtRegisterVPassword.PasswordChar = '*';
            this.TxtRegisterVPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRegisterVPassword.SelectedText = "";
            this.TxtRegisterVPassword.SelectionLength = 0;
            this.TxtRegisterVPassword.SelectionStart = 0;
            this.TxtRegisterVPassword.ShortcutsEnabled = true;
            this.TxtRegisterVPassword.Size = new System.Drawing.Size(268, 35);
            this.TxtRegisterVPassword.TabIndex = 12;
            this.TxtRegisterVPassword.UseSelectable = true;
            this.TxtRegisterVPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRegisterVPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CbxSeePw
            // 
            this.CbxSeePw.AutoSize = true;
            this.CbxSeePw.Location = new System.Drawing.Point(547, 532);
            this.CbxSeePw.Name = "CbxSeePw";
            this.CbxSeePw.Size = new System.Drawing.Size(43, 17);
            this.CbxSeePw.TabIndex = 13;
            this.CbxSeePw.Text = "Ver";
            this.CbxSeePw.UseSelectable = true;
            this.CbxSeePw.CheckedChanged += new System.EventHandler(this.CbxSeePw_CheckedChanged);
            // 
            // CbxSeeVPw
            // 
            this.CbxSeeVPw.AutoSize = true;
            this.CbxSeeVPw.Location = new System.Drawing.Point(547, 588);
            this.CbxSeeVPw.Name = "CbxSeeVPw";
            this.CbxSeeVPw.Size = new System.Drawing.Size(43, 17);
            this.CbxSeeVPw.TabIndex = 14;
            this.CbxSeeVPw.Text = "Ver";
            this.CbxSeeVPw.UseSelectable = true;
            this.CbxSeeVPw.CheckedChanged += new System.EventHandler(this.CbxSeeVPw_CheckedChanged);
            // 
            // PbxRegisterLogo
            // 
            this.PbxRegisterLogo.Image = global::JaguarShop.Properties.Resources.LogoJaguarShopBlack;
            this.PbxRegisterLogo.Location = new System.Drawing.Point(192, 58);
            this.PbxRegisterLogo.Name = "PbxRegisterLogo";
            this.PbxRegisterLogo.Size = new System.Drawing.Size(283, 243);
            this.PbxRegisterLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxRegisterLogo.TabIndex = 15;
            this.PbxRegisterLogo.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 789);
            this.Controls.Add(this.PbxRegisterLogo);
            this.Controls.Add(this.CbxSeeVPw);
            this.Controls.Add(this.CbxSeePw);
            this.Controls.Add(this.TxtRegisterVPassword);
            this.Controls.Add(this.LblRegisterVPassword);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.CmbRegisterRol);
            this.Controls.Add(this.LblRegisterRol);
            this.Controls.Add(this.TxtRegisterPassword);
            this.Controls.Add(this.LblRegisterPassword);
            this.Controls.Add(this.TxtRegisterCif);
            this.Controls.Add(this.LblRegisterCif);
            this.Controls.Add(this.TxtRegisterEmail);
            this.Controls.Add(this.LblRegisterEmail);
            this.Controls.Add(this.TxtRegisterFullName);
            this.Controls.Add(this.LblRegisterFullName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Text = "Registrar Usuario";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.PbxRegisterLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblRegisterFullName;
        private MetroFramework.Controls.MetroTextBox TxtRegisterFullName;
        private MetroFramework.Controls.MetroLabel LblRegisterEmail;
        private MetroFramework.Controls.MetroTextBox TxtRegisterEmail;
        private MetroFramework.Controls.MetroLabel LblRegisterCif;
        private MetroFramework.Controls.MetroTextBox TxtRegisterCif;
        private MetroFramework.Controls.MetroLabel LblRegisterPassword;
        private MetroFramework.Controls.MetroTextBox TxtRegisterPassword;
        private MetroFramework.Controls.MetroLabel LblRegisterRol;
        private MetroFramework.Controls.MetroComboBox CmbRegisterRol;
        private MetroFramework.Controls.MetroButton BtnRegister;
        private MetroFramework.Controls.MetroLabel LblRegisterVPassword;
        private MetroFramework.Controls.MetroTextBox TxtRegisterVPassword;
        private MetroFramework.Controls.MetroCheckBox CbxSeePw;
        private MetroFramework.Controls.MetroCheckBox CbxSeeVPw;
        private System.Windows.Forms.PictureBox PbxRegisterLogo;
    }
}