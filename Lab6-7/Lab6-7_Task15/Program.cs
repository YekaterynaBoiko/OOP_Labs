namespace Lab6_7_Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -4, 5, -99, -2, 16, 0, 28 };
            int sumOfSquares = 0; //сума квадратів
            int count = 0;
            int result = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    sumOfSquares += arr[i] * arr[i];
                }
                if (i % 2 == 0 && arr[i] % 2 != 0)
                {
                    result *= arr[i];
                    count++;
                }
            }
            Console.WriteLine($"Sum: {sumOfSquares}");
            Console.WriteLine($"Result third of the product: {result / 3}");
        }
    }
}
