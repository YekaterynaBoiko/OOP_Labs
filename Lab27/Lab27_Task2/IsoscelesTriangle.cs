using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task2
{
    public class IsoscelesTriangle : Triangle
    {
        public override string FigureName => "Рівнобедрений трикутник";
        public double Site { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return 0.5 * Site * Height;
        }
    }
}
