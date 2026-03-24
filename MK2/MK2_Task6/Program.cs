namespace MK2_Task6
{
    internal class Program
    {
        static int[,] Transposition(int[,] matrix) //поворот на 90 градусів за годинник.стрілкою
        {
            int n = matrix.GetLength(0);
            int[,] resutMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    resutMatrix[j, n - 1 - i] = matrix[i, j];
                }
            }
            return matrix;
        }

        static int[,] CreateMatrix(int n)//створення матриці
        {
            int[,] matrix = new int[n,n];
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = count++;
                }
            }
            return matrix;
        }
        static int[,] RandomMatrixFilling(int n) //рандомне заповнення
        {
            int[,] matrix = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < n; j++)
                {
                    matrix[i, j] = random.Next(1, 11);
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = CreateMatrix(n);
            Console.WriteLine();
            PrintMatrix(matrix);
            Console.WriteLine();
            int[,] resultMatrix = Transposition(matrix);

            Console.WriteLine();
            PrintMatrix(resultMatrix);
        }
    }
}
