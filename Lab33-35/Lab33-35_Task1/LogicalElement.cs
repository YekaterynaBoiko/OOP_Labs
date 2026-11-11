using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_35_Task1
{
    public abstract class LogicalElement
    {
        public bool[] Inputs { get; set; }
        public bool Output => Calc();
        
        protected abstract bool Calc();
    }
}
