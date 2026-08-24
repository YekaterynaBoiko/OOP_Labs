namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string?[] arr = Console.ReadLine().Split();
            int n = Convert.ToInt32(arr[0]);
            int m = Convert.ToInt32(arr[1]);
            int[,] matrix = new int[n, m];
            string?[] array;
            for (int row = 0; row < n; row++) 
            {
                array = Console.ReadLine().Split();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = Convert.ToInt32(array[col]);
                }
            }
            Console.WriteLine(); 
            for (int row = 0; (row < n); row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
