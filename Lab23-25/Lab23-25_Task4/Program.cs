namespace Lab23_25_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber z1 = new ComplexNumber(4, 9);
            ComplexNumber z2 = new ComplexNumber(5, -8);

            ComplexNumber sum = z1 + z2;
            ComplexNumber diff = z1 - z2;
            ComplexNumber mul = z1 * z2;
            ComplexNumber div = z1 / z2;

            Console.WriteLine($"\nsum = {sum.A} + {sum.B}i" +
                $"\ndiff = {diff.A} + {diff.B}i " +
                $"\nmul = {mul.A} + {mul.B}i" +
                $"\ndiv = {div.A} + {div.B}");

            ComplexNumber neg = !z1;
            Console.WriteLine($"!z1 = {neg.A} + {neg.B}i");

            ComplexNumber z3 = new ComplexNumber(4, 9);
            Console.WriteLine($"{z1 == z3}");
            Console.WriteLine($"{z2 == z3}");
        }
    }
}
