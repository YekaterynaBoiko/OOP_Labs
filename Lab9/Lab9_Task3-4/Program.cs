using System.Collections.Specialized;

namespace Lab9_Task3_4
{
    internal class Program
    {

        static List<string> CreateList(int n)
        {
            List<string> list = new List<string>();
            for (int i = 0; i <= n - 1; i++)
            {
                list.Add(i.ToString());
            }
            return list;
        }

        static void RemoveItem(List<string> list)
        {
            list.Remove("текст");
        }

        static void ElementReplacement(List<string> list, int index, string s)
        { //4
            list[index] = s;
        }

        static void PrintList(List<string> list)
        {
            foreach(string item in list)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            int m = Convert.ToInt32 (Console.ReadLine());
            string s = Console.ReadLine();
            List<string> list = CreateList(n);
           
            list.Insert(m, s);
            PrintList(list);
            RemoveItem(list);
            PrintList(list);
            ElementReplacement(list, m, s);
            PrintList (list);
        }
    }
}
