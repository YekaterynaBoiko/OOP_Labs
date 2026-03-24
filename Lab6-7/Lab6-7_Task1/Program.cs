namespace Lab6_7_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int [n];
            for (int i = 1; i <= n; i++)
            {
                array[i - 1] = i;
                Console.Write(array[i - 1] + " "); // n = 5: 1 2 3 4 5
            }
        }// 1 2 3 4 5 
         // 0 1 2 3 4
    }
}
