using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    public class CommercialProperty : RealEstate
    {
        public CommercialProperty(int id, string name, decimal price) : base(id, name, price)
        {
            
        }
        public override decimal CalculateCommission()
        {
            return Price * 0.03m;
        }

        public override decimal RequiredBudget()
        {
            return Price * 20m + Price;
        }


    }
}
// price - 100
// ? - 20