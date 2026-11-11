namespace MK2_Task4
{
    internal class Program
    { 


        static void Main(string[] args)
        {
            string words;
            List<string> list = new List<string>();
            while ((words = Console.ReadLine()) != null)
            {
                if (words == "") continue;
                list.Add(words);
            }
            int j;
            for (int i = 0; i < list.Count; i++)
            {
                for (j = 0; j < list[i].Length; j++)
                {
                    if (!char.IsUpper(list[i][j])) break;
                }
                if (j == list[i].Length)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            foreach (string result in list)
            {
                Console.WriteLine(result);
            }
        }
    }
}
