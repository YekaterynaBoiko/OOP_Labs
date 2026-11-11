namespace Lab9_Task5
{
    internal class Program
    {

        static List<int> GetMergingLists(List<int> list1, List<int> list2) //get явно вказує отримування значення
        {
            List<int> merged = new List<int>(list1);
            merged.AddRange(list2);
            //foreach (int j in list2)
            //{
            //    merged.Add(j);
            //}
            return merged;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list1 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(random.Next(1, 21));
            }
            foreach (int number in list1)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            List<int> list2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(random.Next(1, 21));
            }
            foreach (int number2 in list2)
            {
                Console.Write(number2 + " ");
            }
            Console.WriteLine();

            List<int> resultList = GetMergingLists(list1, list2);
            foreach (int num in resultList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
