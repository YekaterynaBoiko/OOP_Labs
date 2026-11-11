using System;
using System.Linq;
using System.Text;

namespace Lab38_40_Task4
{
    /// <summary>
    /// Головний клас програми: оформлює замовлення двох столів і перевіряє результат.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: приймає замовлення, виводить їх і виконує перевірки.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Стіл 1 обрав українську кухню:");
            Order first = new Order(new UkrainianDishFactory());
            first.AddSoup();
            first.AddMainCourse();
            first.AddAppetizer();
            PrintOrder(first);

            Console.WriteLine();
            Console.WriteLine("Стіл 2 обрав японську кухню:");
            Order second = new Order(new JapaneseDishFactory());
            second.AddSoup();
            second.AddMainCourse();
            second.AddAppetizer();
            PrintOrder(second);

            Console.WriteLine();
            Check("Стіл 1: усі страви з української кухні", AllFrom(first, "українська"));
            Check("Стіл 2: усі страви з японської кухні", AllFrom(second, "японська"));
            Check("Кожне замовлення має першу страву, основну страву й закуску",
                HasFullSet(first) && HasFullSet(second));
        }

        /// <summary>
        /// Виводить страви замовлення на екран.
        /// </summary>
        /// <param name="order">Замовлення.</param>
        private static void PrintOrder(Order order)
        {
            foreach (Dish dish in order.Dishes)
            {
                Console.WriteLine($"  {dish}");
            }
        }

        /// <summary>
        /// Перевіряє, що всі страви замовлення належать до вказаної кухні.
        /// </summary>
        /// <param name="order">Замовлення.</param>
        /// <param name="cuisine">Очікувана кухня.</param>
        /// <returns><c>true</c>, якщо в замовленні є страви і всі вони з цієї кухні.</returns>
        private static bool AllFrom(Order order, string cuisine)
        {
            return order.Dishes.Count > 0 && order.Dishes.All(dish => dish.Cuisine == cuisine);
        }

        /// <summary>
        /// Перевіряє, що замовлення складається з першої страви, основної страви й закуски.
        /// </summary>
        /// <param name="order">Замовлення.</param>
        /// <returns><c>true</c>, якщо набір страв повний і йде в цьому порядку.</returns>
        private static bool HasFullSet(Order order)
        {
            return order.Dishes.Count == 3
                && order.Dishes[0] is Soup
                && order.Dishes[1] is MainCourse
                && order.Dishes[2] is Appetizer;
        }

        /// <summary>
        /// Виводить результат однієї перевірки.
        /// </summary>
        /// <param name="title">Назва перевірки.</param>
        /// <param name="passed">Чи пройдено перевірку.</param>
        private static void Check(string title, bool passed)
        {
            Console.WriteLine(passed ? $"[ПРОЙДЕНО] {title}" : $"[НЕ ПРОЙДЕНО] {title}");
        }
    }
}