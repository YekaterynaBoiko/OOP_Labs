using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task4
{
    public class InvalidAmountExeption : Exception
    {
        public decimal Amount { get; }
        public InvalidAmountExeption(decimal amount) : base($"Некоректна сума {amount} для зняття") 
        {
            Amount = amount;
        }
    }
}
