using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task1
{
    public class ToPowerOf2Raiser : INumericTransformation
    {
        public int Transform(int number)
        {
            return number * number;
        }
    }
}
