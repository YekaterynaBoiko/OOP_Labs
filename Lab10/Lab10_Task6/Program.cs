namespace Lab10_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //; // 10 20 30 40 ... 100 1secound = 1000 miliseconds
            for (int i = 0; i <= 100; i += 10)
            {
                Thread.Sleep(1000);
                Console.Write($"\rLoading: {i}% ");
                
            }
            Console.Write(" \rLoading is completed! "); //_10%_
        }
    }
}
