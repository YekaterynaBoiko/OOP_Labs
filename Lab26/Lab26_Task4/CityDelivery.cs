using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public abstract class CityDelivery : Delivery
    {
        protected CityDelivery(string senderName, string recipientName, double parcelWeight, double distance) 
            : base(senderName, recipientName, parcelWeight, distance)
        {
        }
        public abstract override decimal ShippingCalculation();
    }
}
