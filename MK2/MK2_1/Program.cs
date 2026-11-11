using System.Reflection.Metadata.Ecma335;

namespace MK2_1
{
    internal class Program
    { // повертає масив нат чисел від 1 до н не включно н-кільсть елементів масиву що отримує на вхід у яких лівий і праивй менший за нього 1 2 1 


        static int[] Function1(int[] array)
        {

            // 1 2 1 3 0 2 1 => 3
            // 1 2 
            int n = 0; int i = 0;
            if (array[i - 1] < array[i] && array[i] > array[i + 1])
            {
                n++;
            }
            int[] result = new int[n];
            for (int j = 0; j < n; j++)
            {
                result[i] = i + 1;

            }
            return result;
        }

        static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            Function1([1, 2, 1, 3, 0, 2, 1]);
            printArray(Function1([1, 2, 1, 3, 0, 2, 1]));
        }
    }
}
  