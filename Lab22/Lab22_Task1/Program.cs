namespace Lab22_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.NextMinute();
            Console.WriteLine($"Hour: {clock.Hour} \nMinutes: {clock.Minutes}");

            PreciseClock preciseClock = new PreciseClock();
            preciseClock.NextSecond();
            Console.WriteLine($"Seconds: {preciseClock.Seconds}");
        }
    }
}
