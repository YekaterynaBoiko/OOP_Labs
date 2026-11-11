using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task5
{
    public class OrderSystem
    {
        private Dictionary<string, Product> _products = new();
        public void AddProduct(Product product)
        {
            _products[product.Name] = product;
        }

        public void OrderProcessing(string productName, int quantity)
        {
            if (quantity <= 0)
                throw new InvalidQuantityException(quantity);
            if (!_products.ContainsKey(productName))
                throw new ProductNotFoundException(productName);

            Product product = _products[productName];

            if (product.QuantityRemaining < quantity)
                throw new InsufficientQuantityException(product.QuantityRemaining, quantity, product.Name);

            product.QuantityRemaining -= quantity;
            decimal total = product.Price * quantity;
            Console.WriteLine($"\nЗамовлення: " +
                $"\nНавза: {productName}" +
                $"\nКількість: {quantity}" +
                $"\nДо сплати: {total}");
        }
    } 
}