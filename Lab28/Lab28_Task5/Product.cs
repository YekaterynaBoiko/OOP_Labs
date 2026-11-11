using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task5
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; }
        public int QuantityRemaining { get; set; }
        public Product(string name, decimal price, int quantityRemaining)
        {
            Name = name;
            Price = price;
            QuantityRemaining = quantityRemaining;
        }
    }
}
