using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab22_Task1
{
    public class PreciseClock : Clock
    {
        public int Seconds { get; set; }

        public PreciseClock() 
        {
            Seconds = 0;
        }

        public void NextSecond()
        {
            Seconds++;
            if (Seconds >= 60)
            {
                Seconds = 0;
                NextMinute();
            }
        }
    }
}
