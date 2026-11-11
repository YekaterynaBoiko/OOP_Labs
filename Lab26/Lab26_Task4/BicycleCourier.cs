using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public class BicycleCourier : CityDelivery
    {
        public BicycleCourier(string senderName, string recipientName, double parcelWeight, double distance)
            : base(senderName, recipientName, parcelWeight, distance)
        {
        }
        public override decimal ShippingCalculation()
        {
            return Math.Round(CostDelivery.CostBicycle + ((decimal)ParcelWeight * CostDelivery.PricePerKilogram), 2);
        }
        public override string DeliveryTime() => "2-4 години";
        public override string DeliveryType => "Велокур'єр";
    } 
}
