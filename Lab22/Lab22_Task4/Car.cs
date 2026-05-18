using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task4
{
    public class Car : Transport
    {
        public int AmountOfFuel { get; set; }

        public Car() 
        {
            AmountOfFuel = 0;
        }
        public void Refuel(int fuel)
        {
            AmountOfFuel += fuel;
        }
    }
}
