using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36_37_Task1
{
    public interface ITariff
    {
        public decimal GetMonthlyCost(MobileBill mobileBill);
        public int GetBonusPoints(MobileBill mobileBill);
    }
}
