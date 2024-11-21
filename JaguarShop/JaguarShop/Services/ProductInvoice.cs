using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarShop.Services
{
    public class ProductInvoice
    {
        public void GenerateInvoice()
        {
            // Generar un numero de factura aleatorio
            Random random = new Random();
            int invoiceNumber = random.Next(1000, 9999);
            Console.WriteLine("Factura generada con el número: " + invoiceNumber);
            Console.WriteLine("Gracias por su compra");
        }
    }
}
