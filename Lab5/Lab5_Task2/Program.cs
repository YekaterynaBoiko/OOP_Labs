namespace Lab5_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= m; i++) // sum  по i
            {
                for (int j = 1; j <= n; j++) // sum по j
                {
                    sum += 1.0 / (i + j * j);  // m = 1 n = 2 
                    
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
