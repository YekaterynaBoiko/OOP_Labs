namespace Lab9_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine()); 
                int index = Convert.ToInt32(Console.ReadLine());
                numbers.Insert(index, value);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
