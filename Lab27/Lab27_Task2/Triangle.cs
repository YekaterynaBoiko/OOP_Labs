using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task2
{
    public class Triangle : IShape
    {
        public virtual string FigureName => "Трикутник";
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public virtual double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
