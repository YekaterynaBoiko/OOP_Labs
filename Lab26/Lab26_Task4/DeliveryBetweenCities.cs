using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public abstract class DeliveryBetweenCities : Delivery
    {
        protected DeliveryBetweenCities(string senderName, string recipientName, double parcelWeight, double distance)
            : base(senderName, recipientName, parcelWeight, distance)
        {
        }
    }
}
