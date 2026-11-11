using System;
using System.Collections.Generic;
using System.IO;

namespace Lab38_40_Task3
{
    /// <summary>
    /// Імпортує каталог книг із файлу та повідомляє про результат.
    /// </summary>
    public abstract class BookImporter
    {
        /// <summary>
        /// Імпортує книги з указаного файлу.
        /// </summary>
        /// <param name="path">Повний шлях до файлу.</param>
        /// <returns>Список імпортованих книг.</returns>
        public List<Book> Import(string path)
        {
            Console.WriteLine($"Імпорт файлу {Path.GetFileName(path)}...");

            IBookParser parser = CreateParser();
            List<Book> books = parser.Parse(path);

            Console.WriteLine($"Імпортовано книг: {books.Count}");

            return books;
        }

        public abstract IBookParser CreateParser();
    }
}