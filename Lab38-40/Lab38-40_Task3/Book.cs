namespace Lab38_40_Task3
{
    /// <summary>
    /// Книга з каталогу.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Назва книги.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Автор книги.
        /// </summary>
        public string Author { get; }

        /// <summary>
        /// Рік першого видання.
        /// </summary>
        public int Year { get; }

        /// <summary>
        /// Створює книгу з указаними даними.
        /// </summary>
        /// <param name="title">Назва книги.</param>
        /// <param name="author">Автор книги.</param>
        /// <param name="year">Рік першого видання.</param>
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        /// <summary>
        /// Повертає опис книги одним рядком.
        /// </summary>
        /// <returns>Рядок вигляду «Назва», автор, рік.</returns>
        public override string ToString()
        {
            return $"«{Title}», {Author}, {Year}";
        }
    }
}
