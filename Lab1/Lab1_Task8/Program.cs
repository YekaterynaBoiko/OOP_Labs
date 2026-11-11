namespace Lab1_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            bool isTriangle = ((a + b > c) && (b + c > a) && (c + a > b));
            Console.WriteLine(isTriangle);
        }
    }
}
