using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task3
{
    public interface IDeliveryStrategy
    {
        int DeliveryTime(int distance);
    }
}
