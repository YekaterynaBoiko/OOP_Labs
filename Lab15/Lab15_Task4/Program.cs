using Microsoft.VisualBasic;
using System.Globalization;

namespace Lab15_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string turnOffLights = "2026-01-13T08:00:00+02:00";
            string turnONLights = "2025-01-13T23:50:00+02:00";
            if (DateTimeOffset.TryParse(turnOffLights, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTimeOffset dateOff) && DateTimeOffset.TryParse(turnONLights,
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTimeOffset dateOn))
            {
                Console.WriteLine(dateOff.ToString("dd.MM.yyyy HH:mm:ss"));
                Console.WriteLine(dateOn.ToString("dd.MM.yyyy HH:mm:ss"));
                TimeSpan duration = dateOff - dateOn;
                Console.WriteLine($"Дата відключення: {dateOff:dd:MM:yyyy}");
                Console.WriteLine($"Час початку відключення: {dateOff:HH:mm:ss}");
                Console.WriteLine($"Тривалість роботи акумулятора: {duration.Hours}год {duration.Minutes}хв");
            }
            else Console.WriteLine("Помилка формату дати");
        }
    }
}
