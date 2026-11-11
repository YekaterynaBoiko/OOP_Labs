namespace Lab5_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            for (int i = 1; i <= n; i++) //к-сть рядків
            {
                for (int j = 1; j <= n - i; j++) //крапочки
                {
                    Console.Write('.');
                }
                for (int j = 1; j <= i; j++) //к-сть цифр в рядку 
                {
                    Console.Write($"{i}");
                }
                Console.WriteLine();
            }
        }
    }
}
