namespace Lab6_7_Task10
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
            Console.WriteLine();
            for (int i = 1; i < array.Length - 1; i += 2)
            {
                if (i + 1 < array.Length - 1)
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
