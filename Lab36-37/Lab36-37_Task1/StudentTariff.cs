using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36_37_Task1
{
    public class StudentTariff : ITariff
    {
        public decimal GetMonthlyCost(MobileBill mobileBill)
        {
            int extraGigabytes = Math.Max(0, mobileBill.InternetGigabytes - 10);
            return 60 + mobileBill.CallMinutes + extraGigabytes * 20;
        }
        
        public int GetBonusPoints(MobileBill mobileBill) => (int) (mobileBill.GetMonthlyCost() / 10) * 2;
    }
}
