using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public abstract class Delivery
    {
        public string  UniqueNumber { get; }
        private static int _Number = 100;
        public string SenderName { get; }
        public string RecipientName { get; }
        public double ParcelWeight { get; }
        public double Distance { get; }

        protected Delivery(string senderName, string recipientName, double parcelWeight, double distance)
        {
            UniqueNumber = $"DEL-{_Number++}";
            SenderName = senderName;
            RecipientName = recipientName;
            ParcelWeight = parcelWeight;
            Distance = distance;

            DeliveryJournal.Add(this);
        }
        public abstract decimal ShippingCalculation();
        public abstract string DeliveryTime();
        public abstract void PrintInfo();
    }
}
