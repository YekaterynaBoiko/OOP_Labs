namespace Lab29_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 10, 33, 2, 7 };
            int maxNum = Finder.MaxFinder(numbers);
            Console.WriteLine($"\nMax number: {maxNum}");

            string[] words = { "car", "C#", "apple", "laptop", "computer" };
            string maxWord = Finder.MaxFinder(words);
            Console.WriteLine($"\nMax words: {maxWord}");

            List<Player> players = new List<Player>
            {
                new Player("Mariia", 100),
                new Player("Bob", 320),
                new Player("Anna", 45),
                new Player("Oleg", 390)
            };

            Player winner = Finder.MaxFinder(players);
            Console.WriteLine($"\nWinner: {winner.Name}" +
                $"\nScore: {winner.Score}");
        }
    }
}
