namespace Lab12
{
    internal class Program
    {

        public class Wall
        {
            public double width, height;

            public Wall()
            {
                width = 0;
                height = 0;
            }
            
            public Wall(double width, double height)
            {
                this.width = width;
                this.height = height;
                if (this.width < 0) { this.width = 0; }
                else { this.width = width;  }
                if (this.height < 0) { this.height = 0; }
                else { this.height = height; }
            }

            public double GetArea()
            {
                return width * height;
            }
        }
        static void Main(string[] args)
        {
            Wall wall = new Wall(5.5, 7.5);
            Console.WriteLine(wall.GetArea());

        }
    }
}
