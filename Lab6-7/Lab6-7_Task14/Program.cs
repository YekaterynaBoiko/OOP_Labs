namespace Lab6_7_Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //як в 6 робила, знайти найменший/найбільший +\
            string?[] array = Console.ReadLine().Split('-');
            int[] arr = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = Convert.ToInt32(array[i]);
            }
            Console.WriteLine($"{String.Join(" ", arr)}");
            int minElement = arr[0];
            int maxElement = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
                if (maxElement < arr[i])
                {
                    maxElement = arr[i];
                }
            }
            double average = (minElement + maxElement) / 2.0;
            Console.WriteLine($"Min element: {minElement}");
            Console.WriteLine($"Max element: {maxElement}");
            Console.WriteLine($"Average: {average}");
            

        }
    }
}
