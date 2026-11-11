using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task2
{
    public class Square : Rectangle
    {
        public override string FigureName => "Квадрат";
        public double Site { get; set; }
        public override double Area()
        {
            return Site * Site;
        }
    }
}
