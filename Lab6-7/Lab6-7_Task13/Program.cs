namespace Lab6_7_Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //к-сть чисел у послідовності
            int[] array = new int[n];
            int count = 0; //к-сть міносових
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] < 0)
                {
                    count++;
                }
            }
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(count * a);
        }
    }
}
