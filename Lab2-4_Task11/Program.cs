namespace Lab2_4_Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            bool isTrue = true;
            if (n < 2)
            {
                Console.WriteLine("NO");

            }
            for (int i = 2; i < n; i++) // 3 4 % 2== 0 => no
            {
                if (n % i == 0)
                {
                    isTrue = false;
                    break;
                }
                
            }
            Console.WriteLine(isTrue ? "YES" : "NO");
        }
    }
}
