namespace Lab8_Task9
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
            int magicSum = n * (n * n + 1) / 2;
            bool isMagicquare = true;
            for (int row = 0; row < n; row++)
            {
                int rowSum = 0;
                for (int col = 0; col < n; col++)
                {
                    rowSum += matrix[row, col];
                }
                if (rowSum != magicSum)
                {
                    isMagicquare = false;
                    break;
                }
            }

            if (isMagicquare)
            {
                for (int col = 0; col < n; col++)
                {
                    int colSum = 0;
                    for (int row = 0; row < n; row++)
                    {
                        colSum += matrix[row, col];
                    }
                    if (colSum != magicSum)
                    {
                        isMagicquare = false;
                        break;
                    }
                }
            }
            if (isMagicquare)
            {
                int mainDiag = 0, secondDiag = 0;
                for (int i = 0; i < n; i++)
                {
                    mainDiag += matrix[i, i];
                    secondDiag += matrix[i, n - 1 - i];
                }
                if (mainDiag != magicSum || secondDiag != magicSum)
                {
                    isMagicquare = false;
                }
            }
            Console.WriteLine(isMagicquare);
            
        }
    }
}
