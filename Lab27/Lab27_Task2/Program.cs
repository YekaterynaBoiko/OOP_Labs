namespace Lab27_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes =
            {
                new Circle { Radius = 3 },
                new Rectangle { Site1 = 4, Site2 = 3 },
                new Triangle { a = 3, b = 4, c = 5 },
                new IsoscelesTriangle { Site = 6, Height = 4 },
                new Square { Site = 5 }
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"\nFigure: {shape.FigureName}" +
                    $"\nArea: {shape.Area()}");
            }
        }
    }
}
