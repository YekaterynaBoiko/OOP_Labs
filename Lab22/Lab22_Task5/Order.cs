using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task5
{
    public class Order
    {
        public string Identifier
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Замовлення має мати ідентифікатор!");
                field = value;
            }
        }

        public string Name
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Клієнт повенен мати ім'я!");
                field = value;
            }
        }

        public int BasePrice
        {
            get => field;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Повинна бути встановлена базова ціна!");
                field = value;
            }
        }

        public Order() : this("000", "User") 
        {
        }

        public Order(string identifier, string name) : this(identifier, name, 0)
        {    
        }

        public Order(string identifier) : this(identifier, "User")
        {   
        }

        public Order(string identifier, string name, int basePrice)
        {
            Identifier = identifier;
            Name = name;
            BasePrice = basePrice;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Інформація про продукт: \nІдентифікатор замовлення: {Identifier} \nПродукт: {Name}");
            Console.WriteLine($"\nБазова ціна продукту: {BasePrice}");
        }
    }
}
