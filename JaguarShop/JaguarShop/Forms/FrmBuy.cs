using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JaguarShop.Services;


namespace JaguarShop.Forms
{
    public partial class FrmBuy : MetroFramework.Forms.MetroForm
    {
        public FrmBuy()
        {
            InitializeComponent();
        }

        private void FrmBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmCatalog frmCatalog = new FrmCatalog();
            frmCatalog.Show();
        }

        private void FrmBuy_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 999999);
            LblInvoiceNumber.Text = $"# Factura: {randomNumber.ToString()}";

            LblInvoiceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Obtener el nombre del usuario loggeado
            var (fullName, email) = GetNameAndEmail();
            LblInvoiceName.Text = fullName;
            LblInvoiceEmail.Text = email;
        }

        private (string, string) GetNameAndEmail()
        {
            string fullName = string.Empty;
            string email = string.Empty;
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = Directory.GetFiles(directoryPath, "users_JaguarShop*").FirstOrDefault();

            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                if (lines.Length > 0)
                {
                    fullName = lines.FirstOrDefault(line => line.Contains("Nombre Completo: "));
                    email = lines.FirstOrDefault(line => line.Contains("@"));
                }
            }
            return (fullName, email);
        }
    }
}
