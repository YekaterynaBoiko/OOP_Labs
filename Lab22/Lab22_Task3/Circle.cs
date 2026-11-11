using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task3
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0)
                Radius = 0;
            else
                Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
