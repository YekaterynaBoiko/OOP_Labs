namespace Lab6_7_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            string?[] array = Console.ReadLine().Split(); // "1" "2" "3" !!!Ahtung!!!
            int[] arr = new int[array.Length]; // 0 0 0
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = Convert.ToInt32(array[i]); //розтавляємо на одакові місця з однаковим індексом
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    Console.Write(arr[i] + " ");
                }
            }
            // 8 3 6 3 4 3 12 => 6 4 12
        }
    }
}
