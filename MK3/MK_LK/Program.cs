namespace MK_LK
{
    internal class Program
    {
        public enum TrafficLights
        {
            Red = 1,
            Yellow = 2,
            Green = 3
        }
        static void Main(string[] args)
        {
            TrafficLights trafficLights = TrafficLights.Red;
            Console.WriteLine($"{trafficLights} ({(int)trafficLights})");
            Thread.Sleep(6000);
            trafficLights = TrafficLights.Yellow;
            Console.WriteLine($"{trafficLights} ({(int)trafficLights})");
            Thread.Sleep(3000);
            trafficLights = TrafficLights.Green;
            Console.WriteLine($"{trafficLights} ({(int)trafficLights})");
            Thread.Sleep(5000);

        }
    }
}
