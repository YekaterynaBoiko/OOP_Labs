namespace Lab26_Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Currency dollar = new Dollar();
            Currency euro = new Euro();
            Console.WriteLine($"Amount in USD: {dollar.Convert(1000)} {dollar.CurrencyCode}");
            Console.WriteLine($"Amount in EUR: {euro.Convert(1000)} {euro.CurrencyCode}");
        }
    }
}
