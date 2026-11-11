using System;
using System.Text;

namespace Lab36_37_Task5
{
    /// <summary>
    /// Головний клас програми для роботи з носимими смарт-пристроями.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: показує роботу смарт-годинника та фітнес-браслета.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            SmartWatch watch = new SmartWatch();
            FitnessBand band = new FitnessBand();

            Console.WriteLine("Смарт-годинник:");
            ShowActivity(watch);
            GoToPark(watch);
            PayForCoffee(watch);

            Console.WriteLine();
            Console.WriteLine("Фітнес-браслет:");
            ShowActivity(band);
        }

        /// <summary>
        /// Виводить показники денної активності власника пристрою.
        /// </summary>
        /// <param name="device">Пристрій, з якого беруться показники.</param>
        private static void ShowActivity(ITracker device)
        {
            device.ShowSteps();
            device.ShowPulse();
        }

        /// <summary>
        /// Веде власника пристрою до центрального парку.
        /// </summary>
        /// <param name="device">Пристрій, який прокладає маршрут.</param>
        private static void GoToPark(INavigator device)
        {
            device.BuildRoute("Центральний парк");
            device.ShowNextTurn();
        }

        /// <summary>
        /// Оплачує каву в кав'ярні.
        /// </summary>
        /// <param name="device">Пристрій, яким виконується оплата.</param>
        private static void PayForCoffee(IPayment device)
        {
            device.Pay(85);
        }
    }
}
