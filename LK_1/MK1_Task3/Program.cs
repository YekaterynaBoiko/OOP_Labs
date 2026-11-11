namespace MK1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Sorry, not this number");
            }
            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.Write($"{i} "); // n = 4 дільники: 1, 2, 4
                }
            }
        }
    }
}
