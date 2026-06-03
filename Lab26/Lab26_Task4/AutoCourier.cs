using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public class AutoCourier : CityDelivery
    {
        public string UniqueNumber { get; }
        public string SenderName { get; }
        public string RecipientName { get; }
        public double ParcelWeight { get; }
        public double Distance { get; }
        public AutoCourier(string senderName, string recipientName, double parcelWeight, double distance)
            : base(senderName, recipientName, parcelWeight, distance)
        {
        }
        public override decimal ShippingCalculation()
        {
            return CostDelivery.CostCar + (decimal)Distance * 5 
                + ((decimal)ParcelWeight * CostDelivery.PricePerKilogram);
        }
        public override string DeliveryTime() => "сьогодні або завтра";
        public override void PrintInfo()
        {
            Console.WriteLine($"\n[{UniqueNumber}] Автокур'єр" +
                $"\n{SenderName} -> {RecipientName}" +
                $"\nВага: {ParcelWeight} кг | Дистанція: {Distance} км" +
                $"\nВартість доставки: {ShippingCalculation()} грн" +
                $"\nЧас доставки: {DeliveryTime()}");
        }
    }
}
