namespace Lab5_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // n = 3*a + 5*b
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a = 0; a <= n / 3; a++) { 
                for (int b = 0; b <= n / 5; b++)
                {
                    if (3 * a + 5 * b == n)
                    {
                        Console.WriteLine($"{a} {b}");
                        return; // якщо находить умова то виводить числа та зупиняє все
                    }

                }
            }
            Console.WriteLine("IMPOSSIBLE");
        }
    }
}
