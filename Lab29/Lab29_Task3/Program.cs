namespace Lab29_Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> examples = new()
            {
                "Hello",
                "Bye",
                "Say name",
                "Collection"
            };
            List<Reward> rewards = new()
            {
                new Reward("Bronze Chest", 100),
                new Reward("Silver Chest", 250),
                new Reward("Golden Chest", 500)
            };

            Console.WriteLine("Random phrase: ");
            Console.WriteLine(RandomChoice.PickRandom(examples));
            Console.WriteLine("Random rewards: ");
            Console.WriteLine(RandomChoice.PickRandom(rewards));
        }
    }
}
