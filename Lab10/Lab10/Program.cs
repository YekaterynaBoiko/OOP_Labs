namespace Lab10
{
    internal class Program
    {

        static List<int> IndexesOf(string text, string subsring)
        {
            List<int> indexes2 = new List<int> (); //na: ba na na 2, 4
            int index2 = text.IndexOf(subsring);
            while (index2 != -1)
            {
                indexes2.Add (index2);
                index2 = text.IndexOf (subsring, index2 + 1);
            }
            return indexes2;
        }

        static List<int> IndexesOf(string text, char symbol)
        {
            //int result = text.IndexOf(symbol);
            List<int> indexes = new List<int>(); // a: ba na na 1, 3,
            int index = text.IndexOf(symbol);
            while (index != -1)
            {
                indexes.Add(index);
                index = text.IndexOf(symbol, index + 1); //після знайденого шукаємо інших
            }

            return indexes;
        }
        static void Main(string[] args)
        {
            List<int>result = IndexesOf("banana", 'a');
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List<int> result2 = IndexesOf("banana", "na");
            foreach (int j in result2)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
