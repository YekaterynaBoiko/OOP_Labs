namespace MK2
{
    internal class Program
    { //метод що видаляє цифри, знайде їх суму, і все це повертає, якщо літери великі то вони подвоюються

        static string RemoveNumverAndSum(string text)
        {
            text = text.Trim(); // h4ll0 4 + 0 = 4
            int sum = 0;
            string result = "";
            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    sum += symbol;
                }
                else if (char.IsUpper(symbol))
                {
                    result += symbol + symbol;
                }
                else
                {
                    result += symbol;
                }
            } //word = HeLlo  => if word.ToUpper якщо велика буква то додаю ще одну таку саму
            Console.WriteLine(sum);
            return result;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = RemoveNumverAndSum(text);
            Console.WriteLine(result);
        }
    }
}
