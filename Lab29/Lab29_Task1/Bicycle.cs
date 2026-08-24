using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task1
{
    public class Bicycle : Transport
    {
        public Bicycle(int speed, string model) 
            : base(speed, model){ }

        public override void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }
}
