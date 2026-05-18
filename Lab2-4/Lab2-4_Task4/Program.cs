namespace Lab2_4_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine()); 
            double y = Convert.ToDouble(Console.ReadLine()); // 2x <= y <= 3x

            if (y > 2*x && y < 3*x && y > 0)
            {
                Console.WriteLine("Вітаю!");
            }
            else
            {
                Console.WriteLine("Думай ще");
            }
        }
    }
}
