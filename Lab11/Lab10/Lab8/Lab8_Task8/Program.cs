using System.Data;

namespace Lab8_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n,m];
            string?[] array;
            for (int row = 0; row < n; row++)
            {
                array = Console.ReadLine().Split();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Convert.ToInt32(array[col]);

                }
            }
            
            
            for(int col = 1; col < m; col+=2) //по стовпчиках
            {
                double sum = 0;
                for (int row = 0; row < n; row++) //по елементах
                {
                    sum += matrix[row, col];
                }
                double average = sum / n;
                Console.WriteLine($"Average of col: {col} - {average}");
            }
            
        }
    }
}
