using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    public class House : RealEstate
    {
        public double LandArea { get; set; }
        public House(int id, string name, decimal price, double landArea) 
            : base(id, name, price)
        {
            LandArea = landArea;
        }

        public override decimal CalculateCommission()
        {
            return Price * 0.025m;
        }

        public override decimal RequiredBudget()
        {
            return Price + (decimal)LandArea * 50000.0m;
        }

        public override string Describe()
        {
            return base.Describe() + $"\nПлоща: {LandArea}";
        }
    }
}
