using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public static class DeliveryJournal  
    {
        private static int _Number = 100;
        private static string GenerateUniqueNumber()
        {
            return $"DEL-{_Number++}";
        }
        private static List<Delivery> _deliveries = new();
        public static void Add(Delivery delivery)
        {
            delivery.UniqueNumber = GenerateUniqueNumber();
            _deliveries.Add(delivery);
        } 

        public static int Count => _deliveries.Count;  
        public static decimal TotalRevenue()
        {
            decimal total = 0.0m;
            foreach (var delivery in _deliveries)
                total += delivery.ShippingCalculation();

            return total;
        }
        public static void PrintAllInfo()
        {
            foreach (var delivery in _deliveries)
                delivery.PrintInfo();
        }
    }
}
