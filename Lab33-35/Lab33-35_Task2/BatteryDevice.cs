using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_35_Task2
{
    public class BatteryDevice : Device, IRechargeable
    {
        public int BatteryLevel { get; set; }
        public BatteryDevice(int batteryLevel = 80)
        {
            BatteryLevel = batteryLevel;
        }
        public override void TurnOn()
        {
            if (BatteryLevel > 0)
            {
                IsOn = true;
                Console.WriteLine("Акумулятор увімкнено.");
            }
            else
                Console.WriteLine("Акумулятор розрядився.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Акумулятор вимкнено");
        }

        public void Charge()
        {
            BatteryLevel = 100;
            Console.WriteLine($"Акумулятор заряджено до {BatteryLevel}%");
        }
    }
}
