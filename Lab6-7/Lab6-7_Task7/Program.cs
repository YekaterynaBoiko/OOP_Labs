namespace Lab6_7_Task7
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
            int k = Convert.ToInt32(Console.ReadLine());
            Array.Sort(arr);
            if (k > 0 && k <= arr.Length)
            {
                Console.WriteLine(arr[k - 1]);
            }
            else
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}
