namespace Lab1_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Convert.ToString(Console.ReadLine());
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} {age}");

            int difference = 100 - age;
            int year = 2025 + difference;
            Console.WriteLine("The year when a person turns 100: " + year);
        }
    }
}
