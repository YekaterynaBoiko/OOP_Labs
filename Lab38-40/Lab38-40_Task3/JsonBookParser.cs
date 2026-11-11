using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Lab38_40_Task3
{
    /// <summary>
    /// Читає каталог книг із файлу формату JSON.
    /// </summary>
    public class JsonBookParser : IBookParser
    {
        /// <summary>
        /// Читає книги з указаного JSON-файлу.
        /// </summary>
        /// <param name="path">Повний шлях до файлу.</param>
        /// <returns>Список прочитаних книг.</returns>
        public List<Book> Parse(string path)
        {
            string json = File.ReadAllText(path);

            // Назви полів у файлі записано з малої літери: "title", "author", "year".
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Book>>(json, options);
        }
    }
}
