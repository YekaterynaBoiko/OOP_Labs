namespace Lab26_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arithmeticProgression = new ArithmeticProgression(5, 7);
            GeometricProgression geometricProgression = new GeometricProgression(4, 8);

            int number = 5;

            Console.WriteLine($"Sum of {number} arithmetic progression: {arithmeticProgression.Sum(number)}");
            Console.WriteLine($"Sum of {number} geometric progression: {geometricProgression.Sum(number)}");
        }
    }
}
