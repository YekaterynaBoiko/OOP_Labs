namespace MK1_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Sorry, wrong number");
            }
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 2 * i - 1;
                Console.Write($"{sum} ");
            }
            Console.WriteLine();
        }
    }
}
