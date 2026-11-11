namespace Lab1_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{day}:{month}:{year}");
        }
    }
}
