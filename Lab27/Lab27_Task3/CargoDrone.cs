using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task3
{
    public class CargoDrone : Drone
    {
        public CargoDrone(IDeliveryStrategy strategy) : base("CargoDrone", 10, strategy)
        {  
        }
    }
}
