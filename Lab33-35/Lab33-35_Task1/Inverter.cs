using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_35_Task1
{
    public class Inverter : SingleInputElement
    {
        protected override bool Calc() => !Inputs[0];
    }
}
