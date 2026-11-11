using System.Net.Sockets;

namespace MK1_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            long k = Convert.ToInt64(Console.ReadLine());
            long sum = 0;
            long factorialK = 1; 
            for (int i = 1; i <= k; i++) //для k
                factorialK *= i;

            for (int j = 0; j <= k; j++)
            {
                long factorialJ = 1, factorialKJ = 1; // j and k-j
                for (int i = 1; i <= j; i++) 
                {  
                    factorialJ *= i; 
                }
                for (int i = 1; i <= k - j; i++) 
                { 
                    factorialKJ += i; 
                }
                long stepin = 1;
                for (int i = 1; i <= n; i++) 
                { 
                    stepin *= j; 
                }
                long isEven = ((k + j) % 2 == 0) ? 1 : -1;
                long vuraz = isEven * factorialK / (factorialJ * factorialKJ) * stepin;
                sum += vuraz;
            }
            long S = sum / factorialK;
            Console.WriteLine($"S({n}, {k}) = {S}");
        }
    }
}
