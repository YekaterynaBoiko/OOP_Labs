using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task6
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

        public void AddProduct(Product product)  
        {
            if (product == null)
                throw new ArgumentException("Продукт не може бути пустим!");
            if (!(product is Product))
                throw new InvalidCastException("Можна додати лише продукти");
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new ArgumentException("Ім'я не може бути порожнім!");
            if (product.Price < 0)
                throw new ArgumentException("Ціна не може бути від'ємною!");
            if (product.Amount < 0)
                throw new ArgumentException("Кількість не може бути від'ємною!");
            foreach(var oldproduct in _products)
            {
                if (oldproduct.Equals(product)) 
                {
                    oldproduct.Amount += product.Amount;
                    return;
                }
            }

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

        public override string ToString()
        {
            string result = "";
            foreach (var product in _products)
            {
                result += product + "\n\n";
            }
            result += $"До сплати: {CalcTotal()}";
            return result;
        }
    }
}
