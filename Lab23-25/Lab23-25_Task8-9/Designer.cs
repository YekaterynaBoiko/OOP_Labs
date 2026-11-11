using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task8_9
{
    public class Designer : Employee
    {
        public Designer(string name) : base(name)
        { 
        }

        public void DrawMockup()
        {
            Console.WriteLine($"{Name} мадю макет");
        }
    }
}
