using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab38_40_Task5
{
    /// <summary>
    /// Головний клас програми: наповнює курс діяльностями й перевіряє результат.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: додає на курс тести й завдання, виводить їх і виконує перевірки.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            BlanksStorage blanksStorage = new BlanksStorage();

            Quiz module1 = new Quiz("Модульний контроль 1", 25, 20, 40);
            Quiz module2 = new Quiz("Модульний контроль 2", 25, 20, 40);

            blanksStorage.AddBlank("01 Модульний контроль", module1);
            blanksStorage.AddBlank("02 Модульний контроль", module2);

            FileAssignment lab1 = new FileAssignment("Звіт до лабораторної 1", 5,
                new List<string> { ".pdf", ".docx" });

            FileAssignment lab2 = new FileAssignment("Звіт до лабораторної 2",
                lab1.MaxPoints, lab1.AllowedExtensions);

            blanksStorage.AddBlank("01 Звіт до лабораторної", lab1);
            blanksStorage.AddBlank("02 Звіт до лабораторної", lab2);

            // До другої лабораторної дозволено ще й архів із кодом.
            lab2.AllowedExtensions.Add(".zip");

            Console.WriteLine("Діяльності курсу:");
            Console.WriteLine($"  {module1}");
            Console.WriteLine($"  {module2}");
            Console.WriteLine($"  {lab1}");
            Console.WriteLine($"  {lab2}");

            Console.WriteLine();
            Check("Модульні контролі мають типові налаштування: 25 балів, 20 питань, 40 хв",
                IsModuleTest(module1, "Модульний контроль 1")
                && IsModuleTest(module2, "Модульний контроль 2"));
            Check("Модульні контролі 1 і 2 — це різні об'єкти",
                !ReferenceEquals(module1, module2));
            Check("Звіт до лабораторної 1 приймає лише .pdf і .docx",
                Accepts(lab1, ".pdf", ".docx"));
            Check("Звіт до лабораторної 2 приймає .pdf, .docx і .zip",
                Accepts(lab2, ".pdf", ".docx", ".zip"));
        }

        /// <summary>
        /// Перевіряє, що діяльність є модульним контролем із типовими налаштуваннями.
        /// </summary>
        /// <param name="activity">Діяльність курсу.</param>
        /// <param name="expectedTitle">Очікувана назва.</param>
        /// <returns><c>true</c>, якщо назва й налаштування збігаються з очікуваними.</returns>
        private static bool IsModuleTest(object activity, string expectedTitle)
        {
            return activity is Quiz quiz
                && quiz.Title == expectedTitle
                && quiz.MaxPoints == 25
                && quiz.QuestionCount == 20
                && quiz.TimeLimitMinutes == 40;
        }

        /// <summary>
        /// Перевіряє, що завдання приймає саме вказані розширення файлів.
        /// </summary>
        /// <param name="activity">Діяльність курсу.</param>
        /// <param name="extensions">Очікувані розширення в тому самому порядку.</param>
        /// <returns><c>true</c>, якщо це завдання з файлом і список розширень збігається.</returns>
        private static bool Accepts(object activity, params string[] extensions)
        {
            return activity is FileAssignment assignment
                && assignment.AllowedExtensions.SequenceEqual(extensions);
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
