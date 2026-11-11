namespace Lab9_Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();    
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word1 = Console.ReadLine();
                string word2 = Console.ReadLine();

                words[word1] = word2; // зробити окремий метод для перевірки перевірка на ключ та значення і пвертати рядо не знайдено та зберігаю взагалі одну пару
                words[word2] = word1;
            }
            string synonym = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(words[synonym]);
        }
    }
}
