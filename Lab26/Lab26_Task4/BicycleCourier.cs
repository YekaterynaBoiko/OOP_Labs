using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public class BicycleCourier : CityDelivery
    {
        public string UniqueNumber { get; }
        public string SenderName { get; }
        public string RecipientName { get; }
        public double ParcelWeight { get; }
        public double Distance { get; }
        public BicycleCourier(string senderName, string recipientName, double parcelWeight, double distance)
            : base(senderName, recipientName, parcelWeight, distance)
        {
        }
        public override decimal ShippingCalculation()
        {
            return CostDelivery.CostBicycle + ((decimal)ParcelWeight * CostDelivery.PricePerKilogram);
        }
        public override string DeliveryTime() => "2-4 години";
        public override void PrintInfo()
        {
            Console.WriteLine($"\n[{UniqueNumber}] Велокур'єр" +
                $"\n{SenderName} -> {RecipientName}" +
                $"\nВага: {ParcelWeight} кг | Дистанція: {Distance} км" +
                $"\nВартість доставки: {ShippingCalculation()} грн" +
                $"\nЧас доставки: {DeliveryTime()}"); 
        }
    }
}
