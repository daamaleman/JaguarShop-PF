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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LblProductDescription = new MetroFramework.Controls.MetroLabel();
            this.LblProductPrice = new MetroFramework.Controls.MetroLabel();
            this.NudPrice = new System.Windows.Forms.NumericUpDown();
            this.LblProductColors = new MetroFramework.Controls.MetroLabel();
            this.CbxBlack = new MetroFramework.Controls.MetroCheckBox();
            this.CbxWhite = new MetroFramework.Controls.MetroCheckBox();
            this.CbxOtherColor = new MetroFramework.Controls.MetroCheckBox();
            this.LblStock = new MetroFramework.Controls.MetroLabel();
            this.NudStock = new System.Windows.Forms.NumericUpDown();
            this.BtnSaveProduct = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(118, 120);
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
            this.TxtProductName.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.TxtProductName.CustomButton.Name = "";
            this.TxtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtProductName.CustomButton.TabIndex = 1;
            this.TxtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtProductName.CustomButton.UseSelectable = true;
            this.TxtProductName.CustomButton.Visible = false;
            this.TxtProductName.Lines = new string[0];
            this.TxtProductName.Location = new System.Drawing.Point(197, 120);
            this.TxtProductName.MaxLength = 32767;
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.PasswordChar = '\0';
            this.TxtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtProductName.SelectedText = "";
            this.TxtProductName.SelectionLength = 0;
            this.TxtProductName.SelectionStart = 0;
            this.TxtProductName.ShortcutsEnabled = true;
            this.TxtProductName.Size = new System.Drawing.Size(187, 23);
            this.TxtProductName.TabIndex = 1;
            this.TxtProductName.UseSelectable = true;
            this.TxtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(197, 166);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(187, 64);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // LblProductDescription
            // 
            this.LblProductDescription.AutoSize = true;
            this.LblProductDescription.Location = new System.Drawing.Point(101, 166);
            this.LblProductDescription.Name = "LblProductDescription";
            this.LblProductDescription.Size = new System.Drawing.Size(79, 19);
            this.LblProductDescription.TabIndex = 3;
            this.LblProductDescription.Text = "Descripción:";
            // 
            // LblProductPrice
            // 
            this.LblProductPrice.AutoSize = true;
            this.LblProductPrice.Location = new System.Drawing.Point(131, 256);
            this.LblProductPrice.Name = "LblProductPrice";
            this.LblProductPrice.Size = new System.Drawing.Size(49, 19);
            this.LblProductPrice.TabIndex = 4;
            this.LblProductPrice.Text = "Precio:";
            // 
            // NudPrice
            // 
            this.NudPrice.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NudPrice.Location = new System.Drawing.Point(197, 256);
            this.NudPrice.Name = "NudPrice";
            this.NudPrice.Size = new System.Drawing.Size(120, 20);
            this.NudPrice.TabIndex = 5;
            this.NudPrice.Tag = "";
            this.NudPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudPrice.ThousandsSeparator = true;
            // 
            // LblProductColors
            // 
            this.LblProductColors.AutoSize = true;
            this.LblProductColors.Location = new System.Drawing.Point(53, 306);
            this.LblProductColors.Name = "LblProductColors";
            this.LblProductColors.Size = new System.Drawing.Size(127, 19);
            this.LblProductColors.TabIndex = 6;
            this.LblProductColors.Text = "Colores Disponibles:";
            // 
            // CbxBlack
            // 
            this.CbxBlack.AutoSize = true;
            this.CbxBlack.Location = new System.Drawing.Point(197, 310);
            this.CbxBlack.Name = "CbxBlack";
            this.CbxBlack.Size = new System.Drawing.Size(56, 15);
            this.CbxBlack.TabIndex = 7;
            this.CbxBlack.Text = "Negro";
            this.CbxBlack.UseSelectable = true;
            // 
            // CbxWhite
            // 
            this.CbxWhite.AutoSize = true;
            this.CbxWhite.Location = new System.Drawing.Point(259, 310);
            this.CbxWhite.Name = "CbxWhite";
            this.CbxWhite.Size = new System.Drawing.Size(59, 15);
            this.CbxWhite.TabIndex = 8;
            this.CbxWhite.Text = "Blanco";
            this.CbxWhite.UseSelectable = true;
            // 
            // CbxOtherColor
            // 
            this.CbxOtherColor.AutoSize = true;
            this.CbxOtherColor.Location = new System.Drawing.Point(324, 310);
            this.CbxOtherColor.Name = "CbxOtherColor";
            this.CbxOtherColor.Size = new System.Drawing.Size(47, 15);
            this.CbxOtherColor.TabIndex = 9;
            this.CbxOtherColor.Text = "Otro";
            this.CbxOtherColor.UseSelectable = true;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Location = new System.Drawing.Point(102, 355);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(78, 19);
            this.LblStock.TabIndex = 10;
            this.LblStock.Text = "Disponibles:";
            // 
            // NudStock
            // 
            this.NudStock.Location = new System.Drawing.Point(197, 355);
            this.NudStock.Name = "NudStock";
            this.NudStock.Size = new System.Drawing.Size(120, 20);
            this.NudStock.TabIndex = 11;
            this.NudStock.Tag = "";
            this.NudStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudStock.ThousandsSeparator = true;
            // 
            // BtnSaveProduct
            // 
            this.BtnSaveProduct.Location = new System.Drawing.Point(192, 449);
            this.BtnSaveProduct.Name = "BtnSaveProduct";
            this.BtnSaveProduct.Size = new System.Drawing.Size(125, 62);
            this.BtnSaveProduct.TabIndex = 12;
            this.BtnSaveProduct.Text = "Guardar Producto";
            this.BtnSaveProduct.UseSelectable = true;
            this.BtnSaveProduct.Click += new System.EventHandler(this.BtnSaveProduct_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 547);
            this.Controls.Add(this.BtnSaveProduct);
            this.Controls.Add(this.NudStock);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.CbxOtherColor);
            this.Controls.Add(this.CbxWhite);
            this.Controls.Add(this.CbxBlack);
            this.Controls.Add(this.LblProductColors);
            this.Controls.Add(this.NudPrice);
            this.Controls.Add(this.LblProductPrice);
            this.Controls.Add(this.LblProductDescription);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.LblProductName);
            this.Name = "FrmAdmin";
            this.Text = "Agregar Producto";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.NudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblProductName;
        private MetroFramework.Controls.MetroTextBox TxtProductName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroLabel LblProductDescription;
        private MetroFramework.Controls.MetroLabel LblProductPrice;
        private System.Windows.Forms.NumericUpDown NudPrice;
        private MetroFramework.Controls.MetroLabel LblProductColors;
        private MetroFramework.Controls.MetroCheckBox CbxBlack;
        private MetroFramework.Controls.MetroCheckBox CbxWhite;
        private MetroFramework.Controls.MetroCheckBox CbxOtherColor;
        private MetroFramework.Controls.MetroLabel LblStock;
        private System.Windows.Forms.NumericUpDown NudStock;
        private MetroFramework.Controls.MetroButton BtnSaveProduct;
    }
}