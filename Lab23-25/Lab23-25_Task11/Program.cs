namespace Lab23_25_Task11
{
    public class Program
    {
        public static bool isPalindrome(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                    return false;
            }
            return true;
        }

        public static bool isPalindrome(string[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                    return false;
            }
            return true;
        }

        public static int MaxIndexInArray(int[] arr)
        {
            int maxIndex = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                    maxIndex = i;
            }
            return maxIndex;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 3, 10, 5, 3, 4 };
            string[] text = { "level", "tenet", "hello", "madam"};

            Console.WriteLine(isPalindrome(numbers));
            Console.WriteLine(isPalindrome(text));

            int maxIndex = MaxIndexInArray(numbers);

            bool isPallindrome = isPalindrome(numbers);

            object[] result = new object[2];
            result[0] = maxIndex;
            result[1] = isPallindrome;

            int resultIndex = (int)result[0];
            bool resultPalindrome = (bool)result[1];

            Console.WriteLine(resultIndex);
            Console.WriteLine(resultPalindrome);

        }
    }
} // якийсь статичний метод що порівнювати чи паліндроми 
