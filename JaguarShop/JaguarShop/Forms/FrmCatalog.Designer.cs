namespace JaguarShop.Forms
{
    partial class FrmCatalog
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
            this.BtnAboutUs = new MetroFramework.Controls.MetroButton();
            this.PnCatalog = new MetroFramework.Controls.MetroPanel();
            this.BtnBuyProduct = new MetroFramework.Controls.MetroButton();
            this.LblProductPrice = new MetroFramework.Controls.MetroLabel();
            this.LblProductName = new MetroFramework.Controls.MetroLabel();
            this.PbUAMHat = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnBuyProduct2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LblProductName2 = new MetroFramework.Controls.MetroLabel();
            this.PbUAMTshirt = new System.Windows.Forms.PictureBox();
            this.PbMainPage = new System.Windows.Forms.PictureBox();
            this.BtnAdmin = new MetroFramework.Controls.MetroButton();
            this.PnCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUAMHat)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUAMTshirt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMainPage)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAboutUs
            // 
            this.BtnAboutUs.Location = new System.Drawing.Point(33, 482);
            this.BtnAboutUs.Name = "BtnAboutUs";
            this.BtnAboutUs.Size = new System.Drawing.Size(118, 55);
            this.BtnAboutUs.TabIndex = 1;
            this.BtnAboutUs.Text = "Acerca de Nosotros";
            this.BtnAboutUs.UseSelectable = true;
            this.BtnAboutUs.Click += new System.EventHandler(this.BtnAboutUs_Click);
            // 
            // PnCatalog
            // 
            this.PnCatalog.Controls.Add(this.BtnBuyProduct);
            this.PnCatalog.Controls.Add(this.LblProductPrice);
            this.PnCatalog.Controls.Add(this.LblProductName);
            this.PnCatalog.Controls.Add(this.PbUAMHat);
            this.PnCatalog.HorizontalScrollbarBarColor = true;
            this.PnCatalog.HorizontalScrollbarHighlightOnWheel = false;
            this.PnCatalog.HorizontalScrollbarSize = 10;
            this.PnCatalog.Location = new System.Drawing.Point(225, 97);
            this.PnCatalog.Name = "PnCatalog";
            this.PnCatalog.Size = new System.Drawing.Size(224, 292);
            this.PnCatalog.TabIndex = 3;
            this.PnCatalog.VerticalScrollbarBarColor = true;
            this.PnCatalog.VerticalScrollbarHighlightOnWheel = false;
            this.PnCatalog.VerticalScrollbarSize = 10;
            // 
            // BtnBuyProduct
            // 
            this.BtnBuyProduct.Location = new System.Drawing.Point(68, 237);
            this.BtnBuyProduct.Name = "BtnBuyProduct";
            this.BtnBuyProduct.Size = new System.Drawing.Size(77, 36);
            this.BtnBuyProduct.TabIndex = 5;
            this.BtnBuyProduct.Text = "Comprar";
            this.BtnBuyProduct.UseSelectable = true;
            this.BtnBuyProduct.Click += new System.EventHandler(this.BtnBuyProduct_Click);
            // 
            // LblProductPrice
            // 
            this.LblProductPrice.AutoSize = true;
            this.LblProductPrice.Location = new System.Drawing.Point(68, 198);
            this.LblProductPrice.Name = "LblProductPrice";
            this.LblProductPrice.Size = new System.Drawing.Size(74, 19);
            this.LblProductPrice.TabIndex = 4;
            this.LblProductPrice.Text = "Price: $1.99";
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(68, 164);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(77, 19);
            this.LblProductName.TabIndex = 3;
            this.LblProductName.Text = "Gorra UAM";
            // 
            // PbUAMHat
            // 
            this.PbUAMHat.BackgroundImage = global::JaguarShop.Properties.Resources.Gorra_UAM;
            this.PbUAMHat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbUAMHat.Location = new System.Drawing.Point(16, 13);
            this.PbUAMHat.Name = "PbUAMHat";
            this.PbUAMHat.Size = new System.Drawing.Size(191, 137);
            this.PbUAMHat.TabIndex = 2;
            this.PbUAMHat.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnBuyProduct2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.LblProductName2);
            this.metroPanel1.Controls.Add(this.PbUAMTshirt);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(543, 97);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(224, 292);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnBuyProduct2
            // 
            this.BtnBuyProduct2.Location = new System.Drawing.Point(77, 237);
            this.BtnBuyProduct2.Name = "BtnBuyProduct2";
            this.BtnBuyProduct2.Size = new System.Drawing.Size(77, 36);
            this.BtnBuyProduct2.TabIndex = 6;
            this.BtnBuyProduct2.Text = "Comprar";
            this.BtnBuyProduct2.UseSelectable = true;
            this.BtnBuyProduct2.Click += new System.EventHandler(this.BtnBuyProduct2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 198);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Price: $9.99";
            // 
            // LblProductName2
            // 
            this.LblProductName2.AutoSize = true;
            this.LblProductName2.Location = new System.Drawing.Point(68, 164);
            this.LblProductName2.Name = "LblProductName2";
            this.LblProductName2.Size = new System.Drawing.Size(86, 19);
            this.LblProductName2.TabIndex = 3;
            this.LblProductName2.Text = "Camisa UAM";
            // 
            // PbUAMTshirt
            // 
            this.PbUAMTshirt.BackgroundImage = global::JaguarShop.Properties.Resources.Camisa_UAM;
            this.PbUAMTshirt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbUAMTshirt.Location = new System.Drawing.Point(16, 13);
            this.PbUAMTshirt.Name = "PbUAMTshirt";
            this.PbUAMTshirt.Size = new System.Drawing.Size(191, 137);
            this.PbUAMTshirt.TabIndex = 2;
            this.PbUAMTshirt.TabStop = false;
            // 
            // PbMainPage
            // 
            this.PbMainPage.BackgroundImage = global::JaguarShop.Properties.Resources.LogoJaguarShopBlack;
            this.PbMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbMainPage.Image = global::JaguarShop.Properties.Resources.LogoJaguarShopBlack;
            this.PbMainPage.Location = new System.Drawing.Point(0, 6);
            this.PbMainPage.Name = "PbMainPage";
            this.PbMainPage.Size = new System.Drawing.Size(199, 172);
            this.PbMainPage.TabIndex = 2;
            this.PbMainPage.TabStop = false;
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.Location = new System.Drawing.Point(748, 482);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(118, 55);
            this.BtnAdmin.TabIndex = 5;
            this.BtnAdmin.Text = "Administrador";
            this.BtnAdmin.UseSelectable = true;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // FrmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 571);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.PnCatalog);
            this.Controls.Add(this.PbMainPage);
            this.Controls.Add(this.BtnAboutUs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCatalog";
            this.Padding = new System.Windows.Forms.Padding(30, 94, 30, 31);
            this.Resizable = false;
            this.Text = "Catálogo";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.PnCatalog.ResumeLayout(false);
            this.PnCatalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUAMHat)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUAMTshirt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMainPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnAboutUs;
        private System.Windows.Forms.PictureBox PbMainPage;
        private MetroFramework.Controls.MetroPanel PnCatalog;
        private MetroFramework.Controls.MetroLabel LblProductPrice;
        private MetroFramework.Controls.MetroLabel LblProductName;
        private System.Windows.Forms.PictureBox PbUAMHat;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel LblProductName2;
        private System.Windows.Forms.PictureBox PbUAMTshirt;
        private MetroFramework.Controls.MetroButton BtnBuyProduct;
        private MetroFramework.Controls.MetroButton BtnBuyProduct2;
        private MetroFramework.Controls.MetroButton BtnAdmin;
    }
}