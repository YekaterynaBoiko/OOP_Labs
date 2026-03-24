namespace Lab9_Task12
{
    internal class Program
    {
        static Dictionary<int, int> fib = new Dictionary<int, int>(); //є доступ з усієї част програми

        //рекурсія з кешом(реалізація тимчас сховища)
        
        static int Fibonacci(int n)
        {
            Console.WriteLine($"Fibonacci({n}) ");

            if (n == 1 || n == 2) return 1; 
            if (!fib.ContainsKey(n))
            {
                fib.Add(n, Fibonacci(n - 1) + Fibonacci(n - 2));
            }
            return fib[n]; //готове число
            

        }
        static void Main(string[] args)
        {
            fib.Add(1, 1);
            fib.Add(2, 1);
            Console.WriteLine(Fibonacci(41)); 
        }
    }
}
