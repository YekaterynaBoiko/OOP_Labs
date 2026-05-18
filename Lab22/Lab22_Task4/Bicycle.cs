using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task4
{
    public class Bicycle : Transport
    {
        public int CountOfGears { get; set; }
        public Bicycle()
        {
            CountOfGears = 1;
        }

        public void RingBell()
        {
            Console.WriteLine($"{Name} дзвенить");
        }
    }
}
