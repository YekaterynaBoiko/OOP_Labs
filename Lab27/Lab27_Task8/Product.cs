using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task8
{
    public class Product : IComparable<Product>
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

        public override string ToString()
        {
            return $"Назва продукту: {Name} " +
                $"\nЦіна: {Price}грн " +
                $"\nОпис(г, кг, пляшка і т.д): {Description} " +
                $"\nКількість: {Amount}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Product product)
                return (Name == product.Name && Price == product.Price);

            return false;
        }

        public int CompareTo(Product other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = Price.CompareTo(other.Price);
                if (result == 0)
                {
                    result = Amount.CompareTo(other.Amount);
                }
            }
                
            return result;
        }
    }
}
