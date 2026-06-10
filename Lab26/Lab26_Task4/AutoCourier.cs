using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public class AutoCourier : CityDelivery 
    {
        public AutoCourier(string senderName, string recipientName, double parcelWeight, double distance)
            : base(senderName, recipientName, parcelWeight, distance)
        {
        }
        public override decimal ShippingCalculation()
        {
            return Math.Round(CostDelivery.CostCar + (decimal)Distance * CostDelivery.PricePerKmCar 
                + ((decimal)ParcelWeight * CostDelivery.PricePerKilogram), 2); 
        }
        public override string DeliveryTime() => "сьогодні або завтра";
        public override string DeliveryType => "Автокур'єр";
    }
}
