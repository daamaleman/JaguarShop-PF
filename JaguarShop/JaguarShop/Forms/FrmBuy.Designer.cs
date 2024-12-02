namespace JaguarShop.Forms
{
    partial class FrmBuy
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
            this.LblInvoiceNumber = new MetroFramework.Controls.MetroLabel();
            this.LblInvoiceCostumer = new MetroFramework.Controls.MetroLabel();
            this.LblInvoiceName = new MetroFramework.Controls.MetroLabel();
            this.LblInvoiceEmail = new MetroFramework.Controls.MetroLabel();
            this.LblLine = new MetroFramework.Controls.MetroLabel();
            this.LblInvoiceDate = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LblInvoiceNumber
            // 
            this.LblInvoiceNumber.AutoSize = true;
            this.LblInvoiceNumber.Location = new System.Drawing.Point(539, 60);
            this.LblInvoiceNumber.Name = "LblInvoiceNumber";
            this.LblInvoiceNumber.Size = new System.Drawing.Size(126, 19);
            this.LblInvoiceNumber.TabIndex = 0;
            this.LblInvoiceNumber.Text = "Numero de Factura:";
            // 
            // LblInvoiceCostumer
            // 
            this.LblInvoiceCostumer.AutoSize = true;
            this.LblInvoiceCostumer.Location = new System.Drawing.Point(23, 60);
            this.LblInvoiceCostumer.Name = "LblInvoiceCostumer";
            this.LblInvoiceCostumer.Size = new System.Drawing.Size(52, 19);
            this.LblInvoiceCostumer.TabIndex = 1;
            this.LblInvoiceCostumer.Text = "Cliente:";
            // 
            // LblInvoiceName
            // 
            this.LblInvoiceName.AutoSize = true;
            this.LblInvoiceName.Location = new System.Drawing.Point(23, 91);
            this.LblInvoiceName.Name = "LblInvoiceName";
            this.LblInvoiceName.Size = new System.Drawing.Size(62, 19);
            this.LblInvoiceName.TabIndex = 2;
            this.LblInvoiceName.Text = "Nombre:";
            // 
            // LblInvoiceEmail
            // 
            this.LblInvoiceEmail.AutoSize = true;
            this.LblInvoiceEmail.Location = new System.Drawing.Point(23, 124);
            this.LblInvoiceEmail.Name = "LblInvoiceEmail";
            this.LblInvoiceEmail.Size = new System.Drawing.Size(54, 19);
            this.LblInvoiceEmail.TabIndex = 3;
            this.LblInvoiceEmail.Text = "Correo:";
            // 
            // LblLine
            // 
            this.LblLine.AutoSize = true;
            this.LblLine.Location = new System.Drawing.Point(14, 175);
            this.LblLine.Name = "LblLine";
            this.LblLine.Size = new System.Drawing.Size(651, 19);
            this.LblLine.TabIndex = 4;
            this.LblLine.Text = "_________________________________________________________________________________" +
    "__________________________";
            // 
            // LblInvoiceDate
            // 
            this.LblInvoiceDate.AutoSize = true;
            this.LblInvoiceDate.Location = new System.Drawing.Point(539, 91);
            this.LblInvoiceDate.Name = "LblInvoiceDate";
            this.LblInvoiceDate.Size = new System.Drawing.Size(46, 19);
            this.LblInvoiceDate.TabIndex = 5;
            this.LblInvoiceDate.Text = "Fecha:";
            // 
            // FrmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 218);
            this.Controls.Add(this.LblInvoiceDate);
            this.Controls.Add(this.LblLine);
            this.Controls.Add(this.LblInvoiceEmail);
            this.Controls.Add(this.LblInvoiceName);
            this.Controls.Add(this.LblInvoiceCostumer);
            this.Controls.Add(this.LblInvoiceNumber);
            this.Name = "FrmBuy";
            this.Resizable = false;
            this.Text = "Factura";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBuy_FormClosing);
            this.Load += new System.EventHandler(this.FrmBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblInvoiceNumber;
        private MetroFramework.Controls.MetroLabel LblInvoiceCostumer;
        private MetroFramework.Controls.MetroLabel LblInvoiceName;
        private MetroFramework.Controls.MetroLabel LblInvoiceEmail;
        private MetroFramework.Controls.MetroLabel LblLine;
        private MetroFramework.Controls.MetroLabel LblInvoiceDate;
    }
}