using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaguarShop.Models;

namespace JaguarShop.Services
{
    internal class ProductFile
    {
        private readonly string _filePath;

        public ProductFile()
        {
            _filePath = "JaguarShopProducts.txt";
        }

        // guarda un producto en el archivo
        public void SaveProduct(Product product)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine("-------------------------------");
                writer.WriteLine("ID del Producto: " + product.Id);
                writer.WriteLine("Nombre del Producto: " + product.Name.Trim());
                writer.WriteLine("Descripción: " + product.Description.Trim());
                writer.WriteLine("Precio: " + product.Price);
                writer.WriteLine("Colores: " + product.Colors);
                writer.WriteLine("Stock: " + product.Stock);
                writer.WriteLine("-------------------------------");
            }
        }

        // Carga todos los productos del archivo
        public List<Product> LoadProducts()
        {
            var products = new List<Product>();

            if (!File.Exists(_filePath)) // Verifica si el archivo existe.
            {
                return products; // Devuelve una lista vacía si no existe.
            }

            var lines = File.ReadAllLines(_filePath);

            for (int i = 0; i < lines.Length; i += 7) // Cada proyecto ocupa 7 líneas.
            {
                try
                {
                    var project = new Product
                    {
                        Id = int.Parse(lines[i + 1].Split(':')[1].Trim()),
                        Name = lines[i + 2].Split(':')[1].Trim(),
                        Description = lines[i + 3].Split(':')[1].Trim(),
                        Colors = lines[i + 4].Split(':')[1].Trim(),
                        Stock = int.Parse(lines[i + 5].Split(':')[1].Trim()),
                    };
                    products.Add(project);
                }
                catch
                {
                    // Ignorar líneas mal formateadas.
                }
            }

            return products;
        }

        // Devuelve la ruta del archivo
        public string GetFilePath()
        {
            return _filePath;
        }
    }
}
