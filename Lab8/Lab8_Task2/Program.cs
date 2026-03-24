namespace Lab8_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            int[,] matrixA = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == col) // 1
                    {
                        matrixA[row, col] = 1;
                    }

                    if (row > col)
                    {
                        matrixA[row, col] = 2;
                    }
                }
            }
            int[,] matrixB = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row + col == n - 1)
                    {
                        matrixB[row, col] = 1;
                    }
                    if (row + col > n - 1)
                    {
                        matrixB[row, col] = 2;
                    }
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write (matrixA[row, col] + " ");
                }
                Console.WriteLine ();
            }
            Console.WriteLine ();
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrixB[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
