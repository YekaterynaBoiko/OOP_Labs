using System.Reflection.Metadata.Ecma335;

namespace Lab6_7_Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string?[] array = Console.ReadLine().Split();
            int[] arr = new int[array.Length]; // 0 0 0
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = Convert.ToInt32(array[i]); //розтавляємо на одакові місця з однаковим індексом
            }
            if (array.Length < 3) // 1
            {
                Console.WriteLine("False");
                return;
            }
            int index = 0; // index
            while (arr[index] < arr[index + 1] && index + 1 < array.Length) //вгору
            {
                index++;
            }

            if (index == array.Length - 1 || index == 0)
            {
                Console.WriteLine("False");
                return;
            }

            while (arr[index] >  arr[index + 1] && index + 1 < array.Length)  // 5 1 0 вниз
            {
                index++;
            }
            
            if (index == array.Length - 1) 
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        } //1 2 3 4 3 5
    }
}
