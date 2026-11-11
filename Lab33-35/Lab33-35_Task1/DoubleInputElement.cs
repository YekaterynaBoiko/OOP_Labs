using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_35_Task1
{
    public abstract class DoubleInputElement : LogicalElement
    {
        public DoubleInputElement() : this(new bool[2]) { }
        public DoubleInputElement(bool[] inputs)  
        {
            if (inputs.Length != 2 || inputs == null)
                throw new ArgumentException("DoubleInputElement must have exactly 2 inputs.");

            Inputs = inputs;
        }
    }
}
