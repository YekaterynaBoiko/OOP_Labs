namespace Lab27_Task9
{
    public class Program
    {

        public static void Print(string title, List<StreamingService> streamingServices)
        {
            Console.WriteLine($"\n{title}");
            foreach (var s in streamingServices)
                Console.WriteLine(s);
        }
        static void Main(string[] args) 
        {
            List<StreamingService> streamingServices = new List<StreamingService>()
            {
                new StreamingService("Avatar", 7, 162, 2009),
                new StreamingService("Wednesday", 8, 50, 2022),
                new StreamingService("Dune", 8, 155, 2021),
                new StreamingService("Dark", 9, 60, 2017),
                new StreamingService("Inception", 6, 148, 2010),
                new StreamingService("The Housemaid", 10, 126, 2025)
            };

            streamingServices.Sort(new BestRated());
            Print("Best rating: ", streamingServices);

            streamingServices.Sort(new SortingByDuration());
            Print("Quick View:", streamingServices);

            streamingServices.Sort(new SortingByReleaseYear());
            Print("Novelty:", streamingServices);
        }
    }
}
