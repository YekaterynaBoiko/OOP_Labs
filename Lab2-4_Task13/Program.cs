namespace Lab2_4_Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text; // hello worl cntrZ => 2 
            int sum = 0;
            while ((text = Console.ReadLine()) != null) //nорожнеча
            {
                if (text == "") continue;

                sum++;
            }
            Console.WriteLine(sum);
        }
        
    }
}
