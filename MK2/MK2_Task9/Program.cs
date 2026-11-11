namespace MK2_Task9
{
    internal class Program
    {

        static bool isSlide(int[] array)
        {
            if (array.Length < 3) return false;
            int index = 0;
            while (index + 1 < array.Length && array[index] < array[index + 1])
            {
                index++;
            }
            if (index == 0 || index == array.Length - 1) return false;
            while (index + 1 < array.Length && array[index] > array[index + 1])
            {
                index++;
            }
            return index == array.Length - 1;
        }

        static bool MatrixIsSlide(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                int[] rows = new int[col];
                for (int j = 0; j < col; j++)
                {
                    rows[j] = matrix[i, j];
                }
                if (!isSlide(rows)) return false;
            }

            for (int j = 0; j < col; j++)
            {
                int[] cols = new int[row];
                for (int i = 0; i < row; i++)
                {
                    cols[i] = matrix[i, j];
                }
                if (!isSlide(cols)) return false;
            }
            return true;
        } 


        static void Main(string[] args)
        {
            int[,] matrix =
            {
                {1, 3, 5, 4, 2},
                {2, 4, 6, 5, 3},
                {1, 3, 5, 4, 2 }
            };

            Console.WriteLine(MatrixIsSlide(matrix));
        }
    }
}
