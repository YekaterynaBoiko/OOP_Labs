using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task3
{
    public class ExpressDelivery : IDeliveryStrategy
    {
        public int DeliveryTime(int distance)
        {
            int speed = 60;
            return distance / speed;
        }
    }
}
