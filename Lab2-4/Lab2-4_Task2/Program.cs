namespace Lab2_4_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine((((n = Convert.ToInt32(Console.ReadLine())) % 7 == 0 || n % 17 == 0) && (n >= 1000 && n <= 9999)) ? "Yes" : "No");
        }
    }
}
