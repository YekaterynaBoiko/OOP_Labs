namespace Lab15_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.UtcNow;
            DateTime maxTime = DateTime.MaxValue;
            TimeSpan result = maxTime - now;    
            Console.WriteLine($"До кінця світу залишиось: {result}");

        }
    }
}
