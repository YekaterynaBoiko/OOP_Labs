namespace Lab8_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввід матриці
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
            int bestResult = matrix[0, 0]; // найкращий кидок
            int numberOfPeople = 0; // гравець
            int attempt = 0; //спроба
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (matrix[row, col] > bestResult)
                    {
                        bestResult = matrix[row, col];
                        numberOfPeople = row;
                        attempt = col;
                    }
                }
            }
            Console.WriteLine(bestResult);
            Console.WriteLine($"{numberOfPeople} {attempt}");


        } // найкращий кидок вивести спортсмени рахуються з нуля і номер спрби з нуля
    }
}  
