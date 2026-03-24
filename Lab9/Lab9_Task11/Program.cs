namespace Lab9_Task11
{
    internal class Program
    {
        static double NumberOfDays(double x = 1.0, double day = 1.0)
        {
            if (x >= 100.0) return day;
            return NumberOfDays(x + x / 5.0, day + 1.0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfDays());
        }
    }
}
