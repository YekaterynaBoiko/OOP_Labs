using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task8_9
{
    public class Programmer : Employee
    {
        public Programmer(string name) : base(name)
        { 
        }

        public void WriteCode()
        {
            Console.WriteLine($"{Name} пише код");
        }
    }
}
