using System.Collections.Specialized;

namespace Lab10_Task5
{
    internal class Program
    {
        static void PrintFirstWord(string text)
        {
            int i = 0;
            while (i < text.Length && text[i] == ' ') i++;//hello_ за  indexOf 
            int startWord = i;
            while(i <  text.Length && text[i] != ' ') i++;
            string firstWord = text.Substring(startWord, i  - startWord);   
            Console.WriteLine(firstWord);
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintFirstWord(text); //Hello world! => Hello 
        }
    }
    // text.Trim().Split(' ')[0]; масив із слів 
}
