using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36_37_Task5
{
    public interface IPayment
    {
        /// <summary>
        /// Виконує безконтактну оплату.
        /// </summary>
        /// <param name="amount">Сума оплати у гривнях.</param>
        void Pay(int amount);
    }
}
