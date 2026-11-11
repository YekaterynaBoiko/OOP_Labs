using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_35_Task2
{
    public class HybridDevice : BatteryDevice, IWired
    {
        public HybridDevice(int batteryLevel = 80)
            : base(batteryLevel) { }

        public override void TurnOn()
        {
            if (BatteryLevel > 0)
            {
                IsOn = true;
                Console.WriteLine("Гібридний пристрій увімкнено.");
            }
            else
                Console.WriteLine("Гібрилний пристрій розряджений, зарядіть пристрій.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Гібридний пристрій вимкнено.");
        }

        public void PlugIn()
        {
            Console.WriteLine("Гібридний пристрій підключено.");
            Charge();
        }

        public void Unplug()
        {
            IsOn = false;
            Console.WriteLine("Гібридний пристрій відключено.");
        }
    }
}
