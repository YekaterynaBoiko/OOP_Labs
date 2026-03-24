namespace Lab14_Task3_4
{
    internal class Program
    {
        public class BankAccount
        {
            public string UniqueKey;
            public double SumInUSD;
            public static double CurrentRateUSD = 42.8;
            public static int countOperation = 0;

            public BankAccount(string UniqueKey, double SumInUSD)
            {
                this.UniqueKey = UniqueKey;
                this.SumInUSD = SumInUSD;
            }
            public void TopUpUSD(double sum)
            {
                SumInUSD += sum;
                countOperation++;
                Console.WriteLine($"Ваш рахунок {UniqueKey} поповнено на {sum}USD");
            }

            public void BalanceInUAH()
            {
                double balanceUAH = SumInUSD * CurrentRateUSD;
                Console.WriteLine($"Ваш баланс у гривнях: {balanceUAH}грн");
            }

            public static void RateChangeInBank(double newRate)
            {
                CurrentRateUSD = newRate;
                Console.WriteLine($"Новий курс долару до гривні: {CurrentRateUSD}");
            }

            public static void ShowTransactionsByBank()
            {
                Console.WriteLine($"Загальна кількість транзакцій: {countOperation}");
            }
        }

        public class Admin
        {
            static Dictionary<string, BankAccount> accounts = new Dictionary<string, BankAccount>(); //одна на всіх
            public static BankAccount AccountCreation(double sumBalance = 0)
            {
                Random random = new Random();
                string id;
                do
                {
                    id = "UA-" + random.Next(1000, 9999).ToString();
                }
                while (accounts.ContainsKey(id)); 
              
                BankAccount account = new BankAccount(id, sumBalance);
                accounts.Add(id, account);
                return account;
            }

            public static BankAccount FindAccountByID(string id)
            {
                if (accounts.ContainsKey(id)) return accounts[id];
                Console.WriteLine("Помилка. Вашого рахунку не знайдено!");
                return null;
            }
        }
        static void Main(string[] args)
        {
            BankAccount user1 = Admin.AccountCreation();
            BankAccount user2 = Admin.AccountCreation();

            user1.TopUpUSD(150.0);
            user2.TopUpUSD(200.0);
            user1.BalanceInUAH();
            user2.BalanceInUAH();

            BankAccount.RateChangeInBank(43.4);
            user2.BalanceInUAH();
            BankAccount.ShowTransactionsByBank();

            Random random = new Random();
            string NewID = "UA-" + random.Next(1000, 9999).ToString();
            BankAccount account = Admin.FindAccountByID(NewID);
            if (account != null) Console.WriteLine("Error 404");
        }
    }
}
