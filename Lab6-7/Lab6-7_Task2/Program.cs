namespace Lab6_7_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //спосіб1
            //int n = Convert.ToInt32(Console.ReadLine()); //к-сть чисел у послідовності
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();
             

            //спосіб 2
            int n = Convert.ToInt32(Console.ReadLine()); //к-сть чисел у послідовності
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine($"Last number: {array[n - 1]} Penultimate: {array[n - 2]}");
            int lastScore = array[^1];
            int penultimate = array[^2];
            Console.WriteLine($"Last number: {lastScore} Penultimate: {penultimate}");

            //спосіб 3
            //int n = Convert.ToInt32(Console.ReadLine()); //к-сть чисел у послідовності
            //int[] array = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine(string.Join(" ", array[^2..])); напряму вивести масив НЕ МОЖНА!!!
        }
    }
}
