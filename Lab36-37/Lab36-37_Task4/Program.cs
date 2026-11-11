using System;
using System.Text;

namespace Lab36_37_Task4
{
    /// <summary>
    /// Головний клас програми для автоматичного поливу саду.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: виконує ранкову та вечірню перевірки ґрунту.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            IWateringController wateringController = new AquaLineController();

            GardenWatering watering = new GardenWatering(wateringController, 40);

            Console.WriteLine("Ранкова перевірка ґрунту:");
            watering.WaterIfDry();

            Console.WriteLine();
            Console.WriteLine("Вечірня перевірка ґрунту:");
            watering.WaterIfDry();

            Console.WriteLine();
            Console.WriteLine($"Кількість поливів за день: {watering.WateringCount}");
        }
    }
}