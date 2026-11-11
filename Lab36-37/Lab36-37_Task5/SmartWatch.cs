using System;

namespace Lab36_37_Task5
{
    /// <summary>
    /// Смарт-годинник.
    /// </summary>
    public class SmartWatch : ITracker, INavigator, IPayment
    {
        /// <summary>
        /// Показує кількість кроків за день.
        /// </summary>
        public void ShowSteps()
        {
            Console.WriteLine("Кроків за день: 8450");
        }

        /// <summary>
        /// Показує поточний пульс.
        /// </summary>
        public void ShowPulse()
        {
            Console.WriteLine("Пульс: 72 уд/хв");
        }

        /// <summary>
        /// Будує пішохідний маршрут до вказаної точки.
        /// </summary>
        /// <param name="destination">Назва точки призначення.</param>
        public void BuildRoute(string destination)
        {
            Console.WriteLine($"Маршрут до точки «{destination}» побудовано");
        }

        /// <summary>
        /// Показує наступний поворот маршруту.
        /// </summary>
        public void ShowNextTurn()
        {
            Console.WriteLine("Через 200 м поверніть ліворуч");
        }

        /// <summary>
        /// Виконує безконтактну оплату.
        /// </summary>
        /// <param name="amount">Сума оплати у гривнях.</param>
        public void Pay(int amount)
        {
            Console.WriteLine($"Оплачено {amount} грн");
        }
    }
}
