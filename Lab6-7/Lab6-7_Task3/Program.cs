namespace Lab6_7_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(array[id - 1]);
        }
    }
}
  