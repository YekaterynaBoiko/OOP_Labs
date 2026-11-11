namespace Lab27_Task7
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("ABC", 1),
                new Book("AAA", 1),
                new Book("C#", 2),
                new Book("Meow", 1)
            };

            books.Sort();
            foreach (var book in books)
                book.PrintResult();
        }
    }
}