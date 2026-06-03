using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task3
{
    public class GeometricProgression : Progression
    {
        public double Q { get; set; }
        public GeometricProgression(double a1, double q) : base(a1)
        {
            Q = q;
        }
        public override double Sum(int number)
        {
            if (Q == 1)
                return A1 * number;
            return A1 * (Math.Pow(Q, number) - 1) / (Q - 1);
        }
    }
}
