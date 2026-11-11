namespace Lab22_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4);
            Console.WriteLine($"Area: {circle.GetArea()} \nRadius: {circle.Radius}");

            Cylinder cylinder = new Cylinder(4, 8);
            Console.WriteLine($"Volume: {cylinder.GetVolume()} \nHeight: {cylinder.Height} \nRadius: {cylinder.Radius}");
        }
    }
}
