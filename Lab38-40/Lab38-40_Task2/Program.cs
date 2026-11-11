using System;
using System.Text;

namespace Lab38_40_Task2
{
    /// <summary>
    /// Головний клас програми: звертається до бази міст із двох частин програми
    /// і перевіряє результат.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: показує дані про міста та виконує перевірки.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Довідка про Токіо:");
            Database first = Database.GetInstance();
            Console.WriteLine($"  Населення: {first.GetPopulation("Tokyo")}");

            Console.WriteLine();
            Console.WriteLine("Порівняння Сеула й Делі:");
            Database second = Database.GetInstance();
            int difference = second.GetPopulation("Seoul") - second.GetPopulation("Delhi");
            Console.WriteLine($"  Сеул більший за Делі на {difference} жителів");

            Console.WriteLine();
            Check("Обидві частини програми працюють з одним і тим самим об'єктом бази",
                ReferenceEquals(first, second));
            Check("Створити ще один об'єкт бази оператором new поза класом Database неможливо",
                typeof(Database).GetConstructors().Length == 0);
            Check("Дані з файлу прочитано правильно",
                first.CityCount == 10 && first.GetPopulation("Tokyo") == 33200000);
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