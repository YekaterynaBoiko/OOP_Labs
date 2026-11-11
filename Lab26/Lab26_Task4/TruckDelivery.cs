using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public class TruckDelivery : DeliveryBetweenCities
    {
        public TruckDelivery(string senderName, string recipientName, double parcelWeight, double distance)
            : base(senderName, recipientName, parcelWeight, distance)
        {
        }

        public override decimal ShippingCalculation()
        {
            return Math.Round(CostDelivery.CostTruck + (decimal)Distance * CostDelivery.PricePerKmTruck 
                + (decimal)ParcelWeight * CostDelivery.PricePerKilogram, 2);
        }

        public override string DeliveryTime()
        {
            int days = (int)Math.Ceiling(Distance / 500);
            return $"{days} діб";
        }
        public override string DeliveryType => "Вантажівка";
    }
}
