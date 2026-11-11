namespace Lab12_Task2
{
    internal class Program
    {

        public class Floor
        {
            public double width, height;

            public Floor(double width, double height)
            {
                if (this.width < 0) { this.width = 0; }
                else { this.width = width; }
                if (this.height < 0) { this.height = 0; }
                else { this.height = height; }
            }

            public double GetArea()
            {
                return width * height;
            }
        }

        public class Carpet
        {
            public double cost;
            public Carpet(double cost)
            {
                if (this.cost < 0) { this.cost = 0; }
                else { this.cost = cost; }
            }
        }

        public class Calculator
        {
            public Floor floor;
            public Carpet carpet;

            public Calculator(Floor floor, Carpet carpet)
            {
                this.floor = floor;
                this.carpet = carpet;
            }

            public double GetTotalCost()
            {
                return floor.GetArea() * carpet.cost;
            }
        }
        static void Main(string[] args)
        {
            Floor floor = new Floor(12.0, 10.0);
            Carpet carpet = new Carpet(8.0);

            Calculator calculator = new Calculator(floor, carpet);
            Console.WriteLine($"Total: {calculator.GetTotalCost()}");
        }
    }
}
