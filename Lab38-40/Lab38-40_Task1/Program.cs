using System;
using System.Text;

namespace Lab38_40_Task1
{
    /// <summary>
    /// Головний клас програми: генерує код класів і перевіряє результат.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: виводить згенерований код і звіряє його з очікуваним.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var generator = new ClassGenerator("Person").AddField("Name", "string").AddField("Age", "int");
            Console.WriteLine(generator);
            Console.WriteLine();

            Check("Клас Person із двома полями", generator.ToString(),
                "public class Person",
                "{",
                "  public string Name;",
                "  public int Age;",
                "}");

            Check("Порожній клас Foo", new ClassGenerator("Foo").ToString(),
                "public class Foo",
                "{",
                "}");

            var book = new ClassGenerator("Book")
                .AddField("Title", "string")
                .AddField("Pages", "int")
                .AddField("Price", "decimal");

            Check("Клас Book із трьома полями", book.ToString(),
                "public class Book",
                "{",
                "  public string Title;",
                "  public int Pages;",
                "  public decimal Price;",
                "}");
        }

        /// <summary>
        /// Порівнює згенерований код з очікуваним і виводить результат перевірки.
        /// Пробіли в повідомленні про помилку показано крапками «·».
        /// </summary>
        /// <param name="title">Назва перевірки.</param>
        /// <param name="actual">Згенерований код.</param>
        /// <param name="expectedLines">Рядки очікуваного коду.</param>
        private static void Check(string title, string actual, params string[] expectedLines)
        {
            string expected = string.Join("\n", expectedLines);
            string normalized = actual.Replace("\r\n", "\n").Trim();

            if (normalized == expected)
            {
                Console.WriteLine($"[ПРОЙДЕНО] {title}");
                return;
            }

            Console.WriteLine($"[НЕ ПРОЙДЕНО] {title}");
            Console.WriteLine("Очікувалося:");
            Console.WriteLine(expected.Replace(' ', '·'));
            Console.WriteLine("Отримано:");
            Console.WriteLine(normalized.Replace(' ', '·'));
        }
    }
}