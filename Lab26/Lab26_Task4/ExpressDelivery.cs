using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public class ExpressDelivery : DeliveryBetweenCities
    {
        public ExpressDelivery(string senderName, string recipientName, double parcelWeight, double distance)
            : base(senderName, recipientName, parcelWeight, distance)
        { 
        }

        public override decimal ShippingCalculation()
        {
            return Math.Round(CostDelivery.CostCar + (decimal)Distance * CostDelivery.PricePerKmCar
                + ((decimal)ParcelWeight * CostDelivery.PricePerKilogram) * CostDelivery.CostExpress, 2);
        }

        public override string DeliveryTime() => "завтра";
        public override string DeliveryType => "Експрес";
    }
}
