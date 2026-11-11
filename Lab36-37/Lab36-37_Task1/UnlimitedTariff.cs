using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36_37_Task1
{
    public class UnlimitedTariff : ITariff
    {
        public decimal GetMonthlyCost(MobileBill mobileBill)
        {
            return 350;
        }

        public int GetBonusPoints(MobileBill mobileBill) => 20;
    }
}
