using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task2
{
    public interface IShape
    {
        string FigureName { get; }
        double Area();
    }
}
