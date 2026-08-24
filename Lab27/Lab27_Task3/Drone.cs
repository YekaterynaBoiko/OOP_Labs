using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task3
{
    public abstract class Drone
    {
        public string Name { get; set; }
        public int LoadCapacity { get; set; }
        public IDeliveryStrategy DeliveryStrategy { get; set; }
        protected Drone(string name, int loadCapacity, IDeliveryStrategy strategy)
        {
            Name = name;
            LoadCapacity = loadCapacity;
            DeliveryStrategy = strategy;
        }
        public int DeterminingDelTime(int distance)
        {
            return DeliveryStrategy.DeliveryTime(distance);
        }
    }
}
