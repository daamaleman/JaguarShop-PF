﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JaguarShop.Models;

namespace JaguarShop.Dao
{
    internal class ProductDao
    {
        // listar productos
        private List<Product> products;

        public ProductDao()
        {
            products = new List<Product>();
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public void AddProduct(Product product) 
        {
            products.Add(product);
        }

        public void UpdateProduct(int id, Product updateProject)
        {
            int index = products.FindIndex(product => product.Id == id);
            if (index != -1)
            {
                products[index] = updateProject;
            }
        }
    }
}
