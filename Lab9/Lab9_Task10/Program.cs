namespace Lab9_Task10
{
    internal class Program
    {

        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2) { return 1; }
            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n)); // 7 => 13
        }
    }
}
