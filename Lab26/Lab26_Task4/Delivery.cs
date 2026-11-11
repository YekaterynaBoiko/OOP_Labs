using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public abstract class Delivery
    {
        public string UniqueNumber { get; internal set; }
        public string SenderName { get; }
        public string RecipientName { get; }
        public double ParcelWeight { get; }
        public double Distance { get; }
        public abstract string DeliveryType { get; }
        protected Delivery(string senderName, string recipientName, double parcelWeight, double distance)
        {
            SenderName = senderName;
            RecipientName = recipientName;
            ParcelWeight = parcelWeight;
            Distance = distance;
            DeliveryJournal.Add(this);
        }
        public abstract decimal ShippingCalculation();
        public abstract string DeliveryTime();
        public void PrintInfo()
        {
            Console.WriteLine($"\nНомер: {UniqueNumber} " +
                $"\nТип доставки: {DeliveryType}" +
                $"\n{SenderName} -> {RecipientName}" +
                $"\nВага: {ParcelWeight} кг | Дистанція: {Distance} км" +
                $"\nВартість доставки: {ShippingCalculation()} грн" +
                $"\nЧас доставки: {DeliveryTime()}");
        }
    }
}
