namespace Lab5_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            int count = 0;
            if (n % 2 == 0)
            {
                return;
            }
            Console.WriteLine();
            for (int i = 1; i <= n / 2 + 1; i++) // 7 => 4, 9 => 5, 11 => 6  
            { //основа трикутника
                for (int j = 1; j <= i; j++) // к-сть зірочок
                {
                    Console.Write('*');
                } 
                Console.WriteLine();
            } // 7 => 3, 9 => 4
            for (int i = n / 2; i >= 1; i--) // 3 2 1
            {
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
