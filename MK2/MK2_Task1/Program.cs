namespace MK2_Task1
{
    internal class Program
    {

        static void PrintNumbers(int m)
        {
            if (m == 0) return;
           
            Console.Write(m + " ");
            PrintNumbers(m - 1);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());    
            PrintNumbers(n);
        }
    }
}
