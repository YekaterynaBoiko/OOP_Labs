namespace Lab6_7_Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string?[] array = Console.ReadLine().Split(); // "1" "2" "3" !!!Ahtung!!!
            int[] arr = new int[array.Length]; // 0 0 0
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = Convert.ToInt32(array[i]); //розтавляємо на одакові місця з однаковим індексом
            }
            Array.Sort(arr);
            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }
    }
}
