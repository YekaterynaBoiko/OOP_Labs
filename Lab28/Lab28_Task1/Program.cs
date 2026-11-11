using System.Runtime.InteropServices;

namespace Lab28_Task1
{
    public class Program
    {
        public static double Function(double x)
        {
            if (x == -1)
                throw new DivideByZeroException("При x = -1, значення буде погане");
            return 1 / Math.Pow(1.0 + x, 2);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a number b: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a value to define the step: ");
                double h = Convert.ToDouble(Console.ReadLine());

                for (double x = a; x <= b; x += h)
                {
                    try
                    {
                        Console.WriteLine($"y({x}) =  {Function(x):F4} ");
                    }
                    catch
                    {
                        Console.WriteLine($"y({x}) = Error ");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error 404");
            }
            
        }
    }
}
