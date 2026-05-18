using System.Reflection.Metadata;

namespace Lab2_4_Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double power = 1; // a = 2, n = 2 => power 4
            if (n > 0)
            for (int i = 0; i < n; i++)
            {
                power *= a;
            }
            Console.WriteLine(power);
        }
    }
}
