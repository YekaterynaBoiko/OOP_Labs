using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task3
{
    public class ArithmeticProgression : Progression
    {
        public double D { get; set; }
        public ArithmeticProgression(double a1, double d) : base(a1)
        {
            D = d;
        }
        public override double Sum(int number)
        {
            return number * (2 * A1 + (number - 1) * D) / 2;
        }
    }
}
