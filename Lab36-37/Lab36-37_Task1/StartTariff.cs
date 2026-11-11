using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36_37_Task1
{
    public class StartTariff : ITariff
    {
        public decimal GetMonthlyCost(MobileBill mobileBill)
        {
            int extraMinutes = Math.Max(0, mobileBill.CallMinutes - 100);
            int extraGigabytes = Math.Max(0, mobileBill.InternetGigabytes - 5);
            return 100 + extraMinutes * 2 + extraGigabytes * 30;
        }

        public int GetBonusPoints(MobileBill mobileBill) => (int)(mobileBill.GetMonthlyCost() / 10);
    }
}
