namespace Lab15_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo europeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            TimeZoneInfo tokyoZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            DateTime europeTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, europeZone);
            DateTime tokyoTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, tokyoZone);
            Console.WriteLine($"Час UTC: {utcNow}");
            Console.WriteLine($"Подія за центральноєвропейським часом: {europeTime}");
            Console.WriteLine($"Подія за стандартним часом Токіо: {tokyoTime}");
        }
    }
}
