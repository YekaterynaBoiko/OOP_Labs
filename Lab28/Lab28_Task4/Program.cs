namespace Lab28_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(2000);
            decimal[] amounts = { 300, -10, 10000 };
            foreach (decimal result in amounts)
            {
                try
                {
                    Console.WriteLine($"Спроба зняти {result}");
                    bankAccount.CashWithdrawal(result);
                }
                catch (InvalidAmountExeption ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message} ");
                }
                catch (InsufficientFundsException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
        }
    }
}
