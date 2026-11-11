namespace Lab1_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine()); //місячний бюджет на всіх
            int y = Convert.ToInt32(Console.ReadLine()); //на одного
            //10000 2400
            int c = x / y; //максимальна кільстьь розобникв
            int d = x % y;
            Console.WriteLine(" " + c);
            Console.WriteLine(" " + d);
        }
    }
}
