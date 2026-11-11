namespace Lab27_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Drone drone = new LightDrone(new RegularDelivery());
            Drone drone1 = new CargoDrone(new ExpressDelivery());
            drone.DeliveryStrategy = new ExpressDelivery();
            int distance = 100;
            Console.WriteLine($"{drone.Name}: {drone.DeterminingDelTime(distance)}");
            Console.WriteLine($"{drone1.Name}: {drone1.DeterminingDelTime(distance)}");
        }
    }
}
