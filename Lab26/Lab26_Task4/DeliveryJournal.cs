using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public static class DeliveryJournal  
    {
        private static List<Delivery> deliveries = new();
        public static void Add(Delivery delivery)
        {
            deliveries.Add(delivery);
        } // щоб коли створювали нову доставку то автоматично записує в базу, сам має додавася

        public static int Count => deliveries.Count;  
        public static decimal TotalRevenue()
        {
            decimal total = 0.0m;
            foreach (var delivery in deliveries)
                total += delivery.ShippingCalculation();

            return total;
        }
        public static void PrintAllInfo()
        {
            foreach (var delivery in deliveries)
                delivery.PrintInfo();
        }
    }
}
