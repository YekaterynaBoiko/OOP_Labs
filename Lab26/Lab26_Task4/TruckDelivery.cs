using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public class TruckDelivery : DeliveryBetweenCities
    {
        public string UniqueNumber { get; }
        public string SenderName { get; }
        public string RecipientName { get; }
        public double ParcelWeight { get; }
        public double Distance { get; }

        public TruckDelivery(string senderName, string recipientName, double parcelWeight, double distance)
            : base(senderName, recipientName, parcelWeight, distance)
        {
        }

        public override decimal ShippingCalculation()
        {
            return CostDelivery.CostTruck + (decimal)Distance * 3
                + (decimal)ParcelWeight * CostDelivery.PricePerKilogram;
        }

        public override string DeliveryTime()
        {
            int days = (int)Math.Ceiling(Distance / 500);
            return $"{days} діб";
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"\n[{UniqueNumber}] Вантажівка" +
                $"\n{SenderName} -> {RecipientName}" +
                $"\nВага: {ParcelWeight} кг | Дистанція: {Distance} км" +
                $"\nВартість доставки: {ShippingCalculation()} грн" +
                $"\nЧас доставки: {DeliveryTime()}");
        }
    }
}
