namespace Lab2_4_Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble (Console.ReadLine());
            double y = Convert.ToDouble (Console.ReadLine());
            double km = x; // x це початкове
            int day = 1; // day 1
            while (y > km)
            {
                km += 0.1 * km;
                day++;
            }
            Console.WriteLine(day);
        }
    }
}
