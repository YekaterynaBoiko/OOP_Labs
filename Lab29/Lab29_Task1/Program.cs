namespace Lab29_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200, "Audi");
            Bicycle bicycle = new Bicycle(10, "Cube");
            Garage<Car> garageCar = new Garage<Car>();
            garageCar.AddTransport(car);
            garageCar.PrintTransport();

            Garage<Bicycle> garageBicycle = new Garage<Bicycle>();
            garageBicycle.AddTransport(bicycle);
            garageBicycle.PrintTransport();
        }
    }
}
