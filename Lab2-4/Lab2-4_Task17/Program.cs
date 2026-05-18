namespace Lab2_4_Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            int nnd = 2;
            while (n % nnd != 0)
            {
                nnd++;
            }
            Console.WriteLine(nnd); 
        }
    }
}
