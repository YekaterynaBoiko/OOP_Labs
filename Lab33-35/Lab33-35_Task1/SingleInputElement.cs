using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_35_Task1
{
    public abstract class SingleInputElement : LogicalElement
    {
        public SingleInputElement() : this(new bool[1])  { }
        public SingleInputElement(bool[] inputs)
        {
            if (inputs.Length != 1 || inputs == null)
                throw new ArgumentException("SingleInputElement must have exactly 1 input.");

            Inputs = inputs;
        }
    }
}
