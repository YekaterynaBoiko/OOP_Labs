using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task1
{
    public class Car : Transport
    {
        public Car(int speed, string model) 
            : base(speed, model) { }

        public override void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
