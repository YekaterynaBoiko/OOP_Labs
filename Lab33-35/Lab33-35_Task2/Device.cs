using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_35_Task2
{
    public abstract class Device : ISwitchable
    {
        public bool IsOn { get; set; }
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
