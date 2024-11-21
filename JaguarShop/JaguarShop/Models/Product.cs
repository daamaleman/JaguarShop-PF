using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaguarShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Styles { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
    }
}
