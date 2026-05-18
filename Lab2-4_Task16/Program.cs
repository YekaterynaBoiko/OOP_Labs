namespace Lab2_4_Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int dobutok = 1;
            int count = 0;
            while (dobutok < n)
            {
                int newNumber = Convert.ToInt32(Console.ReadLine());
                dobutok *= newNumber;
                count++;
            } 
            Console.WriteLine($"{count} {dobutok}");
        }
    } // 5 * 0 = 0, 10 * 0 = 0 // n = 4, 1 2 3 => 6 > 4
}
