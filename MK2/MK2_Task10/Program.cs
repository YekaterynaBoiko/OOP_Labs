namespace MK2_Task10
{
    internal class Program
    {// || 

        static void Module(ref int number)
        {
            if (number < 0)
            {
                number = - number;
            }
        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Module(ref number);
            Console.WriteLine(number);
        }
    }
}
