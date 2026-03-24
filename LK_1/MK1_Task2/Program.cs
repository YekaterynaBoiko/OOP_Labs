namespace MK1_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            if (y >= x && y <= 2 - x * x || y <= x && y >= 0 && y <= 2 - x*x)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO"); // x = 1, y = 0,5  NO має бути YES
            }
        }
    }
}
