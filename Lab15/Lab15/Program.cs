namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            TimeOnly currentTime = TimeOnly.FromDateTime(now);
            TimeOnly startWork = new TimeOnly(8, 0);
            TimeOnly endWork = new TimeOnly(18, 0);
            if (currentTime >= startWork && currentTime <= endWork)
                Console.WriteLine("Час потрапляє в інтервал робочого дня");
            else Console.WriteLine("Час не потрапляє до інтервалу робочого дня"); 
        }
    }
}
