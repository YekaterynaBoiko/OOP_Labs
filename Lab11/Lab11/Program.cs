namespace Lab11
{
    internal class Program
    { //Task 2


        public class Rectangle
        {
            public double side1, side2;

            public double GetArea()
            {
                return side1 * side2;
            }

            public double GetPerimeter()
            {
                return 2.0 * side1 + 2.0 * side2;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
                rectangle.side1 = 6.5;
                rectangle.side2 = 3.5;
                Console.WriteLine($"Area: {rectangle.GetArea()}; Perimeter: {rectangle.GetPerimeter()}");


        }
    }
}
