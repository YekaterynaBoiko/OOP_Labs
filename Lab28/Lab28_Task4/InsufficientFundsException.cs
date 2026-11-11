using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task4
{
    public class InsufficientFundsException : Exception
    {
        public decimal Balance { get; }
        public decimal Amount { get; }
        public InsufficientFundsException(decimal amount, decimal balance) 
            : base($"Ви намагались зняти {amount} грн" +
            $"\nНа вашому рахунку {balance} грн") 
        {
            Balance = balance;
            Amount = amount;
        }
    }
}
