namespace Lab2_4_Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int maxNumber = 0;
            while ((n = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                if (maxNumber < n)
                {
                    maxNumber = n;
                }
            }
            Console.WriteLine();
               Console.WriteLine(maxNumber);
        }
    }
}
