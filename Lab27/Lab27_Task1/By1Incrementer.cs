using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task1
{
    public class By1Incrementer : INumericTransformation
    {
        public int Transform(int number)
        {
            return ++number;
        }
    }
}
