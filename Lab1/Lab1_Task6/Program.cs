namespace Lab1_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            bool isYearLeap = (year % 400 == 0 || year % 100 != 0 && year % 4 == 0); //викосний

            Console.WriteLine(isYearLeap);
        }
    }
}
