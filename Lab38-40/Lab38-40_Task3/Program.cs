using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab38_40_Task3
{
    /// <summary>
    /// Головний клас програми: імпортує каталоги книг із файлів, які обрав користувач,
    /// і перевіряє результат.
    /// </summary>
    class Program
    {

        public static BookImporter CreateImporter(string fileName)
        {
            switch(Path.GetExtension(fileName).ToLowerInvariant())
            {
                case ".json": 
                    return new JsonBookImporter();
                case ".xml": 
                    return new XmlBookImporter();
                default:
                    throw new NotSupportedException("Notsupported file format");
            }
        }
        /// <summary>
        /// Точка входу: імпортує обидва файли й виконує перевірки.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Book> jsonBooks = ImportFile("books.json");
            Console.WriteLine();
            List<Book> xmlBooks = ImportFile("books.xml");

            Console.WriteLine();
            Check("Імпорт books.json", jsonBooks, "Кобзар");
            Check("Імпорт books.xml", xmlBooks, "Захар Беркут");
        }

        /// <summary>
        /// Імпортує каталог книг із файлу, який обрав користувач, і виводить його на екран.
        /// </summary>
        /// <param name="fileName">Назва файлу в папці з програмою.</param>
        /// <returns>Прочитані книги або <c>null</c>, якщо імпорт не вдався.</returns>
        private static List<Book> ImportFile(string fileName)
        {
            Console.WriteLine($"Користувач обрав файл {fileName}");
            string path = Path.Combine(AppContext.BaseDirectory, fileName);

            try
            {
                BookImporter importer = CreateImporter(fileName);
                List<Book> books = importer.Import(path);

                foreach (Book book in books)
                {
                    Console.WriteLine($"  {book}");
                }

                return books;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"  Помилка імпорту: {exception.Message}");
                return null;
            }
        }

        /// <summary>
        /// Перевіряє, що з файлу прочитано три книги і першою йде очікувана.
        /// </summary>
        /// <param name="title">Назва перевірки.</param>
        /// <param name="books">Прочитані книги.</param>
        /// <param name="expectedFirstTitle">Назва книги, яка має йти першою.</param>
        private static void Check(string title, List<Book> books, string expectedFirstTitle)
        {
            bool passed = books != null && books.Count == 3 && books[0].Title == expectedFirstTitle;
            Console.WriteLine(passed ? $"[ПРОЙДЕНО] {title}" : $"[НЕ ПРОЙДЕНО] {title}");
        }
    }
}
