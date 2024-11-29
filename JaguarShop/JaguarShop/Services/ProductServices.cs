using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using JaguarShop.Models;

namespace JaguarShop.Services
{
    internal class ProductServices
    {
        private readonly ProductFile _productFile;

        public ProductServices()
        {
            _productFile = new ProductFile();
        }

        // validar que los campos no esten vacios
        public bool ValidateFields(string name, string description, float price, string colors, int stock, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || price <= 0 || string.IsNullOrWhiteSpace(colors) || stock <= 0)
            {
                errorMessage = "Todos los campos son obligatorios";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }

        // Crear nuevo producto
        public Product CreateProduct(string name, string description, float price, string colors, int stock)
        {
            return new Product
            {
                Id = new Random().Next(1, 1000),
                Name = name,
                Description = description,
                Price = price,
                Colors = colors,
                Stock = stock
            };
        }

        // Guardar producto en archivo
        public void SaveProduct(Product product)
        {
            _productFile.SaveProduct(product);
        }
    }
}
