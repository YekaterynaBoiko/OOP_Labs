namespace Lab5_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            { //зовнішній к-сть рядків і вивід від А до В
                for (int j = 1; j <= i; j++) //цифри та їх кількість
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }
}
