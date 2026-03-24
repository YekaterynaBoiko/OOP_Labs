using System.Data;

namespace Lab9
{
    internal class Program
    {
        //Task 1-2
        static int[] GetSumOfRow(int[,] matrix) //1 get отримує
        {
            //одновимірний масив і його повертаємо довжина=к-сть рядків матриці //створити мсаив
            //повертаємо к-сть
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] sums = new int[rows];
            for (int row = 0; row < rows; row++)
            {
                int sum = 0;
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
                sums[row] = sum;
            }
            return sums;
        } 
        static void PrintResult(int[] sums)//1
        {
            //масив сум
            foreach (int s in sums)
            {
                Console.WriteLine(s);
            }
        }


        static int[,] MakeNewMatrix(int n, int m) //2
        {
            int[,] matrix = new int[n, m];
            int value = 1;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = value++;
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)//2
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            string?[] arr = Console.ReadLine().Split(',');
            int n = Convert.ToInt32(arr[0]);
            int m = Convert.ToInt32(arr[1]);
            int[,] matrix = new int[n, m];
            for (int row = 0; row < n; row++)
            {
                string[] array = Console.ReadLine().Split();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Convert.ToInt32(array[col]);
                }
            }
            int[] rowSums = GetSumOfRow(matrix);
            PrintResult(rowSums);

            int[,] creatMatrix = MakeNewMatrix(n, m);
            PrintMatrix(creatMatrix);

        }
    }
}
