namespace JaguarShop.Forms
{
    partial class FrmAppConfig
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
            this.LblTheme = new MetroFramework.Controls.MetroLabel();
            this.CbxTheme = new MetroFramework.Controls.MetroCheckBox();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            this.PbImage = new System.Windows.Forms.PictureBox();
            this.LblAply = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTheme
            // 
            this.LblTheme.AutoSize = true;
            this.LblTheme.Location = new System.Drawing.Point(147, 298);
            this.LblTheme.Name = "LblTheme";
            this.LblTheme.Size = new System.Drawing.Size(43, 19);
            this.LblTheme.TabIndex = 2;
            this.LblTheme.Text = "Tema:";
            // 
            // CbxTheme
            // 
            this.CbxTheme.AutoSize = true;
            this.CbxTheme.Location = new System.Drawing.Point(232, 302);
            this.CbxTheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CbxTheme.Name = "CbxTheme";
            this.CbxTheme.Size = new System.Drawing.Size(47, 15);
            this.CbxTheme.TabIndex = 3;
            this.CbxTheme.Text = "Dark";
            this.CbxTheme.UseSelectable = true;
            this.CbxTheme.CheckedChanged += new System.EventHandler(this.CbxTheme_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = global::JaguarShop.Properties.Resources.agregado;
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSave.Location = new System.Drawing.Point(159, 385);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(119, 82);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackgroundImage = global::JaguarShop.Properties.Resources._return;
            this.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReturn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnReturn.Location = new System.Drawing.Point(374, 79);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(46, 50);
            this.BtnReturn.TabIndex = 1;
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // PbImage
            // 
            this.PbImage.Image = global::JaguarShop.Properties.Resources.LogoJaguarShopBlack;
            this.PbImage.Location = new System.Drawing.Point(159, 90);
            this.PbImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PbImage.Name = "PbImage";
            this.PbImage.Size = new System.Drawing.Size(119, 125);
            this.PbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbImage.TabIndex = 0;
            this.PbImage.TabStop = false;
            // 
            // LblAply
            // 
            this.LblAply.AutoSize = true;
            this.LblAply.Location = new System.Drawing.Point(197, 471);
            this.LblAply.Name = "LblAply";
            this.LblAply.Size = new System.Drawing.Size(50, 19);
            this.LblAply.TabIndex = 5;
            this.LblAply.Text = "Aplicar";
            // 
            // FrmAppConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 509);
            this.Controls.Add(this.LblAply);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CbxTheme);
            this.Controls.Add(this.LblTheme);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.PbImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAppConfig";
            this.Padding = new System.Windows.Forms.Padding(22, 75, 22, 25);
            this.Resizable = false;
            this.Text = "Configuración de la App";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.PbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbImage;
        private MetroFramework.Controls.MetroButton BtnReturn;
        private MetroFramework.Controls.MetroLabel LblTheme;
        private MetroFramework.Controls.MetroCheckBox CbxTheme;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroLabel LblAply;
    }
}