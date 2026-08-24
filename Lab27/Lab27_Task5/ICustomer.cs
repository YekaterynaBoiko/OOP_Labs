using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task5
{
    public interface ICustomer
    {
        double Discount();

        double CalculatePriceWithDiscount(double orderAmount)
        {
            return orderAmount * (1 - Discount() / 100);
        }
    }
}
