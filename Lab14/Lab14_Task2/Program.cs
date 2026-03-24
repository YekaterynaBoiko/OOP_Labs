using System.Diagnostics.CodeAnalysis;

namespace Lab14_Task2
{
    internal class Program
    {
        public class MathUtils
        {
            public double a;
            public double b;
            public MathUtils(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

            public static double Addition(double a, double b) 
            { 
                double result = a + b;
                Console.WriteLine(result);
                return result; 
            }
            public static double Subtraction(double a, double b) 
            { 
                double result = a - b;
                Console.WriteLine(result);
                return result; 
            }
            public static double Multiplication(double a, double b) 
            { 
                double result = a * b;
                Console.WriteLine(result);
                return result; 
            }
            public static double Divide(double a, double b) 
            {
                double result;
                if (b == 0)
                {
                    Console.WriteLine("Error 404");
                    return 0;
                }
                else
                {
                    result = a / b;
                    Console.WriteLine(result);
                }
                return result;
            }
            public static double GetPerimeter(double a, double b) 
            {
                double result = 2.0 * a + 2.0 * b;
                Console.WriteLine(result);
                return result; 
            }
            public static double GetArea(double a, double b) 
            {
                double result = a * b;
                Console.WriteLine(result);
                return result; 
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            while(true)
            {
                Console.WriteLine("\nChoose a number: \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Divide \n5. GetPerimeter \n6. GetArea \n7. Exit the program");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        MathUtils.Addition(a, b); break;
                    case "2":
                        MathUtils.Subtraction(a, b); break;
                    case "3":
                        MathUtils.Multiplication(a, b); break;
                    case "4":
                        MathUtils.Divide(a, b); break;
                    case "5":
                        MathUtils.GetPerimeter(a, b); break;
                    case "6":
                        MathUtils.GetArea(a, b); break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Error 404"); break;
                }
            }
        }
    }
}
