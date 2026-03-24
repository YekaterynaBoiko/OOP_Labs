namespace Lab8_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            string?[] array;
            for (int row = 0; row < n; row++)
            {
                array = Console.ReadLine().Split();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = Convert.ToInt32(array[col]);

                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] != 0)
                    {
                        Console.WriteLine($"Index: [{row}, {col}]");
                    }
                }
            }

        }
    }
}
