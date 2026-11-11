using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Task5
{
    public class Product 
    {
        public required string Name 
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ім'я не може бути порожнім!");
                field = value;
            }
        }

        public required double Price 
        {
            get => field;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Ціна не може бути від'ємною!");
                field = value;
            }
        }
        public string Description 
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Опис товару не може бути порожнім!");
                field = value;
            }
        }
        public double Amount 
        {
            get => field;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Кількість товару від'ємною бути не може!");
                field = value;
            }
        }
        //public Product(string name, double price, string description, double amount)
        //{
        //    Name = name;
        //    Price = price;
        //    Description = description;
        //    Amount = amount;
        //}
    }
}
