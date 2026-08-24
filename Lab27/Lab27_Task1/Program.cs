using System.Security.Cryptography.X509Certificates;

namespace Lab27_Task1
{
    public class Program
    {
        public static int Transform(int number)
        {
            List<INumericTransformation> list = new List<INumericTransformation> { new By1Incrementer(), new By2Multiplier(), 
                new ToPowerOf2Raiser() };
            
            foreach (INumericTransformation transformation in list)
            {
                number = transformation.Transform(number);
            }
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"\nResult: {Transform(5)}");
        }
    }
}
