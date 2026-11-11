using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_35_Task2
{
    public class WiredDevice :  Device, IWired
    {
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Дротовий пристрій увімкнено.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Дротовий пристрій вимкнено");
        }

        public void PlugIn()
        {
            Console.WriteLine("Пристрій підключено.");
        }

        public void Unplug()
        {
            Console.WriteLine("Пристрій не підключено.");
        }
    }
}