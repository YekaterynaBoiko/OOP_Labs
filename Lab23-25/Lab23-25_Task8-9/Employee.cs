using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task8_9
{
    public class Employee
    {
       public string Name { get; set; }
       public bool isWork { get; set; }
        public Employee(string name)
        {
            Name = name;
            isWork = true;
        }
    }
}
