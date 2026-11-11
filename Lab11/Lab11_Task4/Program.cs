namespace Lab11_Task4
{
    internal class Program
    {

        public class Book
        {
            public Title Title;
            public Author Author;
            public Content Content;
            public void Show()
            {
                Title.Show();
                Author.Show();
                Content.Show();
            }
        }

        public class Title
        {
            public string Name;
            public void Show()
            {
                Console.WriteLine(Name);
            }
        }

        public class  Author
        {
            public string Name;
            public void Show()
            {
                Console.WriteLine(Name);
            }
        }

        public class Content
        {
            public string Title;
            public void Show()
            {
                Console.WriteLine(Title);
            }
        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = new Title();
            book.Title.Name = "Corrupt";
            book.Author = new Author();
            book.Author.Name = "Penelope Douglas";
            book.Content = new Content();
            book.Content.Title = "Content about the devil's night";

            book.Show();
        }
    }
}
