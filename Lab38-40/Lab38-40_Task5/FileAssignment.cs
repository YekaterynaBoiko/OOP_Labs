using System.Collections.Generic;

namespace Lab38_40_Task5
{
    /// <summary>
    /// Завдання, у якому студент прикріплює файл, наприклад звіт.
    /// </summary>
    public class FileAssignment : IPrototype
    {
        /// <summary>
        /// Назва завдання, яку бачать студенти.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Максимальна кількість балів за завдання.
        /// </summary>
        public int MaxPoints { get; }

        /// <summary>
        /// Розширення файлів, які система приймає, наприклад ".pdf".
        /// </summary>
        public List<string> AllowedExtensions { get; }

        /// <summary>
        /// Створює завдання з указаними налаштуваннями.
        /// </summary>
        /// <param name="title">Назва завдання.</param>
        /// <param name="maxPoints">Максимальна кількість балів.</param>
        /// <param name="allowedExtensions">Розширення файлів, які система приймає.</param>
        public FileAssignment(string title, int maxPoints, List<string> allowedExtensions)
        {
            Title = title;
            MaxPoints = maxPoints;
            AllowedExtensions = allowedExtensions;
        }

        public FileAssignment(FileAssignment other)
            : this(other.Title, other.MaxPoints, new List<string> (other.AllowedExtensions))
        {
        }

        public IPrototype Clone() => new FileAssignment(this);

        public string GetType() => "Завдання з файлом";

        /// <summary>
        /// Повертає опис завдання одним рядком.
        /// </summary>
        /// <returns>Назва та налаштування завдання.</returns>
        public override string ToString()
        {
            string extensions = string.Join(", ", AllowedExtensions);
            return $"Завдання «{Title}»: {MaxPoints} балів, файли {extensions}";
        }
    }
}