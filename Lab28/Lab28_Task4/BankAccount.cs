using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task4
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public void CashWithdrawal(decimal amount)
        {
            if (amount <= 0)
                throw new InvalidAmountExeption(amount);

            if (amount > Balance)
                throw new InsufficientFundsException(amount, Balance);

            Balance -= amount;
            Console.WriteLine($"Було знято {amount} грн \nНа балансі: {Balance} грн");
        }
    }
}
