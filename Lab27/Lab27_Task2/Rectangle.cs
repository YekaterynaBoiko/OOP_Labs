using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task2
{
    public class Rectangle : IShape
    {
        public virtual string FigureName => "Прямокутник";
        public double Site1 { get; set; }
        public double Site2 { get; set; }
        public virtual double Area()
        {
            return Site1 * Site2;
        }
    }
}
