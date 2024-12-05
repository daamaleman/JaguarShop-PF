namespace JaguarShop.Forms
{
    partial class FrmAdmin
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
            this.LblProductName = new MetroFramework.Controls.MetroLabel();
            this.TxtProductName = new MetroFramework.Controls.MetroTextBox();
            this.RtbProductDescrip = new System.Windows.Forms.RichTextBox();
            this.LblProductDescription = new MetroFramework.Controls.MetroLabel();
            this.LblProductPrice = new MetroFramework.Controls.MetroLabel();
            this.NudProductPrice = new System.Windows.Forms.NumericUpDown();
            this.LblProductColors = new MetroFramework.Controls.MetroLabel();
            this.CbxProductCBlack = new MetroFramework.Controls.MetroCheckBox();
            this.CbxProductCWhite = new MetroFramework.Controls.MetroCheckBox();
            this.CbxProductOtherColor = new MetroFramework.Controls.MetroCheckBox();
            this.LblStock = new MetroFramework.Controls.MetroLabel();
            this.NudProductStock = new System.Windows.Forms.NumericUpDown();
            this.Lbl = new MetroFramework.Controls.MetroLabel();
            this.BtnSaveProduct = new MetroFramework.Controls.MetroButton();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.NudProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudProductStock)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(157, 148);
            this.LblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(62, 19);
            this.LblProductName.TabIndex = 0;
            this.LblProductName.Text = "Nombre:";
            // 
            // TxtProductName
            // 
            // 
            // 
            // 
            this.TxtProductName.CustomButton.Image = null;
            this.TxtProductName.CustomButton.Location = new System.Drawing.Point(223, 2);
            this.TxtProductName.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductName.CustomButton.Name = "";
            this.TxtProductName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.TxtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProductName.CustomButton.TabIndex = 1;
            this.TxtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProductName.CustomButton.UseSelectable = true;
            this.TxtProductName.CustomButton.Visible = false;
            this.TxtProductName.Lines = new string[0];
            this.TxtProductName.Location = new System.Drawing.Point(263, 148);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductName.MaxLength = 32767;
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.PasswordChar = '\0';
            this.TxtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProductName.SelectedText = "";
            this.TxtProductName.SelectionLength = 0;
            this.TxtProductName.SelectionStart = 0;
            this.TxtProductName.ShortcutsEnabled = true;
            this.TxtProductName.Size = new System.Drawing.Size(249, 28);
            this.TxtProductName.TabIndex = 1;
            this.TxtProductName.UseSelectable = true;
            this.TxtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RtbProductDescrip
            // 
            this.RtbProductDescrip.Location = new System.Drawing.Point(263, 204);
            this.RtbProductDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.RtbProductDescrip.Name = "RtbProductDescrip";
            this.RtbProductDescrip.Size = new System.Drawing.Size(248, 78);
            this.RtbProductDescrip.TabIndex = 2;
            this.RtbProductDescrip.Text = "";
            // 
            // LblProductDescription
            // 
            this.LblProductDescription.AutoSize = true;
            this.LblProductDescription.Location = new System.Drawing.Point(135, 204);
            this.LblProductDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductDescription.Name = "LblProductDescription";
            this.LblProductDescription.Size = new System.Drawing.Size(79, 19);
            this.LblProductDescription.TabIndex = 3;
            this.LblProductDescription.Text = "Descripción:";
            // 
            // LblProductPrice
            // 
            this.LblProductPrice.AutoSize = true;
            this.LblProductPrice.Location = new System.Drawing.Point(175, 315);
            this.LblProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductPrice.Name = "LblProductPrice";
            this.LblProductPrice.Size = new System.Drawing.Size(49, 19);
            this.LblProductPrice.TabIndex = 4;
            this.LblProductPrice.Text = "Precio:";
            // 
            // NudProductPrice
            // 
            this.NudProductPrice.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudProductPrice.Location = new System.Drawing.Point(263, 315);
            this.NudProductPrice.Margin = new System.Windows.Forms.Padding(4);
            this.NudProductPrice.Name = "NudProductPrice";
            this.NudProductPrice.Size = new System.Drawing.Size(160, 22);
            this.NudProductPrice.TabIndex = 5;
            this.NudProductPrice.Tag = "";
            this.NudProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudProductPrice.ThousandsSeparator = true;
            // 
            // LblProductColors
            // 
            this.LblProductColors.AutoSize = true;
            this.LblProductColors.Location = new System.Drawing.Point(71, 377);
            this.LblProductColors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductColors.Name = "LblProductColors";
            this.LblProductColors.Size = new System.Drawing.Size(127, 19);
            this.LblProductColors.TabIndex = 6;
            this.LblProductColors.Text = "Colores Disponibles:";
            // 
            // CbxProductCBlack
            // 
            this.CbxProductCBlack.AutoSize = true;
            this.CbxProductCBlack.Location = new System.Drawing.Point(263, 382);
            this.CbxProductCBlack.Margin = new System.Windows.Forms.Padding(4);
            this.CbxProductCBlack.Name = "CbxProductCBlack";
            this.CbxProductCBlack.Size = new System.Drawing.Size(56, 15);
            this.CbxProductCBlack.TabIndex = 7;
            this.CbxProductCBlack.Text = "Negro";
            this.CbxProductCBlack.UseSelectable = true;
            // 
            // CbxProductCWhite
            // 
            this.CbxProductCWhite.AutoSize = true;
            this.CbxProductCWhite.Location = new System.Drawing.Point(345, 382);
            this.CbxProductCWhite.Margin = new System.Windows.Forms.Padding(4);
            this.CbxProductCWhite.Name = "CbxProductCWhite";
            this.CbxProductCWhite.Size = new System.Drawing.Size(59, 15);
            this.CbxProductCWhite.TabIndex = 8;
            this.CbxProductCWhite.Text = "Blanco";
            this.CbxProductCWhite.UseSelectable = true;
            // 
            // CbxProductOtherColor
            // 
            this.CbxProductOtherColor.AutoSize = true;
            this.CbxProductOtherColor.Location = new System.Drawing.Point(432, 382);
            this.CbxProductOtherColor.Margin = new System.Windows.Forms.Padding(4);
            this.CbxProductOtherColor.Name = "CbxProductOtherColor";
            this.CbxProductOtherColor.Size = new System.Drawing.Size(47, 15);
            this.CbxProductOtherColor.TabIndex = 9;
            this.CbxProductOtherColor.Text = "Otro";
            this.CbxProductOtherColor.UseSelectable = true;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(136, 437);
            this.LblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(78, 19);
            this.LblStock.TabIndex = 10;
            this.LblStock.Text = "Disponibles:";
            // 
            // NudProductStock
            // 
            this.NudProductStock.Location = new System.Drawing.Point(263, 437);
            this.NudProductStock.Margin = new System.Windows.Forms.Padding(4);
            this.NudProductStock.Name = "NudProductStock";
            this.NudProductStock.Size = new System.Drawing.Size(160, 22);
            this.NudProductStock.TabIndex = 11;
            this.NudProductStock.Tag = "";
            this.NudProductStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudProductStock.ThousandsSeparator = true;
            // 
            // Lbl
            // 
            this.Lbl.AutoSize = true;
            this.Lbl.Location = new System.Drawing.Point(289, 629);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(115, 19);
            this.Lbl.TabIndex = 13;
            this.Lbl.Text = "Guardar Producto";
            // 
            // BtnSaveProduct
            // 
            this.BtnSaveProduct.BackgroundImage = global::JaguarShop.Properties.Resources.Guardar;
            this.BtnSaveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSaveProduct.Location = new System.Drawing.Point(263, 532);
            this.BtnSaveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSaveProduct.Name = "BtnSaveProduct";
            this.BtnSaveProduct.Size = new System.Drawing.Size(167, 91);
            this.BtnSaveProduct.TabIndex = 12;
            this.BtnSaveProduct.UseSelectable = true;
            this.BtnSaveProduct.Click += new System.EventHandler(this.BtnSaveProduct_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackgroundImage = global::JaguarShop.Properties.Resources._return;
            this.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReturn.Location = new System.Drawing.Point(615, 77);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(66, 63);
            this.BtnReturn.TabIndex = 14;
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 673);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.BtnSaveProduct);
            this.Controls.Add(this.NudProductStock);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.CbxProductOtherColor);
            this.Controls.Add(this.CbxProductCWhite);
            this.Controls.Add(this.CbxProductCBlack);
            this.Controls.Add(this.LblProductColors);
            this.Controls.Add(this.NudProductPrice);
            this.Controls.Add(this.LblProductPrice);
            this.Controls.Add(this.LblProductDescription);
            this.Controls.Add(this.RtbProductDescrip);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.LblProductName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdmin";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "Agregar Producto";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudProductStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblProductName;
        private MetroFramework.Controls.MetroTextBox TxtProductName;
        private System.Windows.Forms.RichTextBox RtbProductDescrip;
        private MetroFramework.Controls.MetroLabel LblProductDescription;
        private MetroFramework.Controls.MetroLabel LblProductPrice;
        private System.Windows.Forms.NumericUpDown NudProductPrice;
        private MetroFramework.Controls.MetroLabel LblProductColors;
        private MetroFramework.Controls.MetroCheckBox CbxProductCBlack;
        private MetroFramework.Controls.MetroCheckBox CbxProductCWhite;
        private MetroFramework.Controls.MetroCheckBox CbxProductOtherColor;
        private MetroFramework.Controls.MetroLabel LblStock;
        private System.Windows.Forms.NumericUpDown NudProductStock;
        private MetroFramework.Controls.MetroButton BtnSaveProduct;
        private MetroFramework.Controls.MetroLabel Lbl;
        private MetroFramework.Controls.MetroButton BtnReturn;
    }
}