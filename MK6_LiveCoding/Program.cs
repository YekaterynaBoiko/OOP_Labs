using System.ComponentModel;

namespace MK6_LiveCoding
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayList repition = new PlayList("Повтор");
            PlayList favorite = new PlayList("Улюблені");
            MusicComposition rock1 = new RockMusic("Believer", 
                "Imagine Dragons", 
                new TimeSpan(0, 3, 25));
            MusicComposition rock2 = new RockMusic("Stones",
                "The Hardkiss", new TimeSpan(0, 3, 48));
            MusicComposition pop1 = new PopMusic("Save Your Tears",
                "The Weekend", new TimeSpan(0, 3, 36));
            MusicComposition pop2 = new PopMusic("Shape of You",
                "Ed Sheeran", 
                new TimeSpan(0, 3, 53));
            MusicComposition jazz1 = new JazzMusic("Take Five",
                "Dave Brubeck",
                new TimeSpan(0, 5, 24));
            MusicComposition jazz2 = new JazzMusic("Abracadabra",
                "aaaaa", new TimeSpan(0, 6, 36));

            repition.AddComposition(rock1);
            repition.AddComposition(jazz2);
            repition.AddComposition(pop1);
            repition.AddComposition(pop2);

            favorite.AddComposition(rock2);
            favorite.AddComposition(jazz1);
            favorite.AddComposition(pop1);

            Console.WriteLine(repition);
            Console.WriteLine(favorite);
            Console.WriteLine($"Пошук за жанром: {repition.FindByGenres(rock1.Genre)}");        

        }
    }
}
