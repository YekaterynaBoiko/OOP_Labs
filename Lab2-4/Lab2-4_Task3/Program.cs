namespace Lab2_4_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine()); //-1 <= x <= 1 ||
            double y = Convert.ToDouble(Console.ReadLine()); //-1 <= y <= 1 || x*x+y*y=>1

            if (x >= -1 && x <= 1 && y >= -1 && y <= 1 && x*x+y*y >= 1)
            {
                Console.WriteLine("Круто");
            }
            else
            {
                Console.WriteLine("Думай ще");
            }

        }
    }
}
