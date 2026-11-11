namespace MK2_Task2
{
    internal class Program
    {

        static int Akkerman(int m, int n)
        {
            if (m == 0) return n + 1;
            if (m > 0 && n == 0) return Akkerman(m - 1, 1);
            if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Akkerman(1, 1));
        }
    }
}
