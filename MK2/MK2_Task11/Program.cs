namespace MK2_Task11
{
    internal class Program
    {
        static int NSDandNSK(int a, int b, out int nsk)
        {
            int x = a;
            int y = b;
            while (y != 0) // алгоритм евкліда 
            {
                int surplusFromDivision = x % y;
                x = y;
                y = surplusFromDivision;
            }
            int nsd = x;
            nsk = (a * b) / nsd;
            return nsd;

        }
        
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int nsk;
            int nsd = NSDandNSK(x, y, out nsk);
            Console.WriteLine(nsd);
            Console.WriteLine(nsk);

        }
    }
}
// string? name = null