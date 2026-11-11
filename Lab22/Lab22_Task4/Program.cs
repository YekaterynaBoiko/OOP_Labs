namespace Lab22_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Name = "Audi", Speed = 200, AmountOfFuel = 50 };
            Bicycle bicycle = new Bicycle { Name = "Cube", Speed = 40, CountOfGears = 3 };

            car.Move();
            car.Refuel(5);
            bicycle.Move();
            bicycle.RingBell();
        }
    }
}
