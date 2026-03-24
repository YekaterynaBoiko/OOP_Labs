namespace Lab6_7_Task12
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
            if (arr.Length < 3)
            {
                Console.WriteLine(0);
                return;
            }
            int sumMin = arr[0] + arr[2];
            for (int i = 1; i < arr.Length - 2; i++)
            {
                if (arr[i] + arr[i + 2] < sumMin)
                {
                    sumMin = arr[i] + arr[i + 2];
                }
            }
            Console.WriteLine(sumMin);
        }
    }
}
