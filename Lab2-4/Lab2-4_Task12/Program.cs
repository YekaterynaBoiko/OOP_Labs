namespace Lab2_4_Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                Console.Write($"{n} ");
            }
            
        }
    }
}
