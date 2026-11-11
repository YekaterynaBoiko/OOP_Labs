using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task4
{
    public static class CostDelivery
    { 
        public static decimal CostBicycle { get; } = 50.0m;
        public static decimal CostCar { get; } = 80.0m;
        public static decimal CostTruck { get; } = 200.0m;
        public static decimal CostExpress { get; } = 1.5m;
        public static decimal PricePerKilogram { get; } = 10.0m;
        public static decimal PricePerKmCar { get; } = 5.0m;
        public static decimal PricePerKmTruck { get; } = 3.0m;
    }
}
