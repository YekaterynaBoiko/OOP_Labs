namespace Lab2_4_Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (2.0 * i + 1.0);
            }
            Console.WriteLine(sum);
        }
    }
}
