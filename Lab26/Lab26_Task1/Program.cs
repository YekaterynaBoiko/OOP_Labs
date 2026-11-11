namespace Lab26_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = { new Wolf(), new Hare(), new Fox(), new Deer() };
            int countWolf = 0;
            int countFox = 0;
            int countDeer = 0;
            int countHare = 0;
            int countPredators = 0;
            int countHerbivorous = 0;
            foreach (var animal in animals)
            {
                switch(animal)
                {
                    case Wolf:
                        countWolf++;
                        countPredators++;
                        break;
                    case Fox:
                        countFox++;
                        countPredators++;
                        break;
                    case Hare:
                        countHare++;
                        countHerbivorous++;
                        break;
                    case Deer:
                        countDeer++;
                        countHerbivorous++;
                        break;
                        
                }


            }
            Console.WriteLine($"Wolf: {countWolf}");
            Console.WriteLine($"\nFox: {countFox}");
            Console.WriteLine($"\nHare: {countHare}");
            Console.WriteLine($"\nDeer: {countDeer}");
            Console.WriteLine($"\nPredators: {countPredators}");
            Console.WriteLine($"\nHerbivorous: {countHerbivorous}");

        }
    }
}
