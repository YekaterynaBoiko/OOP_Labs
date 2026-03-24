namespace Lab6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 4
            int n = Convert.ToInt32 (Console.ReadLine());
            int sum = 0;
            int count = 0;
            int[] array = new int[n / 2];
            // n = 5 => 2 4 5, n= 8 => 2 4 6 8, n = 10: 2 4 6 8 10 sum 30
            for (int i = 2; i <= n; i+=2)
            {
                array[count] = i;
               
                Console.Write(array[count] + " ");
                count++;
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    } // n =5: i = 2 
}
