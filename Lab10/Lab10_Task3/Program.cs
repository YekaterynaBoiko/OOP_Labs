namespace Lab10_Task3
{
    internal class Program
    {
        static bool IsPalindromTask(string text) //нову змінну додавати перезаписувати
        {
            text = text.Trim().ToLower();
            string reversed = new string(text.Reverse().ToArray());
            return text == reversed;
        } //tenet 
        static bool IsPalindrom(string word) //рядки не змінні!!!
        {
            word = word.Trim().ToLower(); //перезаписала змінну щоб працювати з тими штуками
            int left = 0;
            int right = word.Length - 1;
            while (left < right)
            {
                if (word[left] != word[right]) return false;
                left++;
                right--;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(IsPalindrom(text));
            Console.WriteLine(IsPalindromTask(text));
        }
    }
}
