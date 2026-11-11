namespace Lab1_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d1 = a + b + c;
            double d2 = a * b * c;
            double d3 = a + b + c / 3;
            Console.WriteLine($"{a}+{b}+{c}={d1}");
            Console.WriteLine($"{a}*{b}*{c}={d2}");
            Console.WriteLine($"({a}+{b}+{c})/3={(Math.Round(d3, 3))}");
        }
    }
}
