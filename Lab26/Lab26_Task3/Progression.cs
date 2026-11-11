using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task3
{
    public abstract class Progression
    {
        public double A1 { get; set; }
        protected Progression(double a1)
        {
            A1 = a1;
        }
        public abstract double Sum(int number);
    }
}
