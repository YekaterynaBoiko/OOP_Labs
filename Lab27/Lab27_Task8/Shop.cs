using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task8
{
    public class Shop
    {
        private Dictionary<string, Product> _products = new();

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentException("Продукт не може бути порожнім");

            if (_products.ContainsKey(product.Name))
                _products[product.Name].Amount += product.Amount;
            else
                _products.Add(product.Name, product);
        }

        public Product GetProduct(string name)
        {
            if (_products.ContainsKey(name))
                return _products[name];

            throw new ArgumentException("Продукт не знайдено");
        }

        public void RemoveProduct(string name)
        {
            if (_products.Remove(name))
                throw new ArgumentException("Продукт не знайдено");
        }

        public void ShowProducts()
        {
            foreach (var product in _products.Values)
                Console.WriteLine(product);
        }
    }
} 
