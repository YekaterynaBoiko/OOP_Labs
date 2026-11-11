using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task4
{
    public class Transport
    {
        public required string Name
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Транспорт має містити ім'я");

                field = value;
            }
        }

        public int Speed { get; set; }

        public Transport()
        {
            Name = "No name";
            Speed = 0;
        }

        public void Move()
        {
            Console.WriteLine($"{Name} рухається зі швидкістю {Speed} км/год");
        }
    }
}
