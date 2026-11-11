namespace Lab5_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32 (Console.ReadLine());
            int b = Convert.ToInt32 (Console.ReadLine());
            for (int i = a; i <= b; i++)
            {  //вивід від .. до ...
                for (int j = a; j <= i; j++) //к-сть відтворень
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
