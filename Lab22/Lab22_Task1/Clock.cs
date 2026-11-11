using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task1
{
    public class Clock
    {
        public int Hour { get; set; }
        public int Minutes { get; set; }

        public Clock()
        {
            Hour = 0;
            Minutes = 0;
        }

        public void NextMinute()
        {
            Minutes++;
            if (Minutes >= 60)
            {
                Minutes = 0;
                Hour++;
            }

            if (Hour >= 24) Hour = 0;
        }
    }
}
