namespace Lab5_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); //зовнішній за рядки, 

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine(i);
            }
        }
    }
}
