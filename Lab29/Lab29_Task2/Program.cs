namespace Lab29_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Stack<string> browserHistory = new Stack<string>();

            browserHistory.Push("google.com");
            browserHistory.Push("youtube.com");
            browserHistory.Push("github.com");
            browserHistory.Push("wikipedia.org");

            Console.WriteLine("\nПоточна сторінка: " + browserHistory.Peek());
            Console.WriteLine("\nКількість сайтів в історії: " + browserHistory.Count);
            Console.WriteLine("\nСтек порожній? " + browserHistory.IsEmpty);
            Console.WriteLine("\nНатиснули кнопку 'Назад':");
            Console.WriteLine("\nЗакрили: " + browserHistory.Pop());
            Console.WriteLine("\nТепер відкрита сторінка: " + browserHistory.Peek());
            Console.WriteLine("\nКількість сайтів: " + browserHistory.Count);
            Console.WriteLine("\nОчищаємо історію:");

            while (!browserHistory.IsEmpty)
                Console.WriteLine(browserHistory.Pop());

            Console.WriteLine("\nСтек порожній? " + browserHistory.IsEmpty);
        }
    }
}
