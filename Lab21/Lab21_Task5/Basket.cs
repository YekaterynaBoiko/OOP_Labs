using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Task5
{
    public class Basket
    {
        private List<Product> _products = new List<Product>(); // приватні іменувати через _ підчеркування
        public int Count => _products.Count;

        public Product this[int index]
        {
            get
            {
                if (index < 0 || index >= _products.Count)
                    throw new ArgumentException("Некоректний індекс продукту");
                return _products[index];
            }
        }

        public Product this[string name]
        {
            get
            {
                foreach (var product in _products)
                {
                    if (product.Name == name)
                        return product;
                }
                throw new ArgumentException("Продукт не знайдено");
            }
        }

        public void AddProduct(Product product)  //зробити перевірку
        {
            if (product == null)
                throw new ArgumentException("Продукт не може бути пустим!");
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ArgumentException("Ім'я не може бути порожнім!");
            if (product.Price < 0)
                throw new ArgumentException("Ціна не може бути від'ємною!");
            if (product.Amount < 0)
                throw new ArgumentException("Кількість не може бути від'ємною!");
            _products.Add(product);
        }

        public void RemoveProductByName(string name)
        {
            for (int i =0; i < _products.Count; i++)
            {
                if (_products[i].Name == name)
                {
                    _products.RemoveAt(i);
                    return;
                }
            }
            throw new ArgumentException("Продукт не знайдено!");
        }

        public double CalcTotal()
        {
            double sum = 0;
            foreach (var product in _products)
                sum += product.Price * product.Amount;

            return sum;
        }

        //public Product SearchByName(string name) // індексатор за іменем
        //{
        //    return this[name];
        //}

        public void PrintShoppingInfo()
        {
            foreach (var product in _products)
            {
                Console.WriteLine($"Назва продукту: {product.Name} \nЦіна: {product.Price}грн \nОпис(г, кг, пляшка і т.д): {product.Description} \nКількість: {product.Amount}");
            }

            Console.WriteLine(CalcTotal());
        }
    }
}
