namespace MK2_Task7
{
    internal class Program
    {
        static bool XoRFunction(bool x, bool y)
        {
            return x != y; 
        }
        static void Main(string[] args)
        {
                
            Console.WriteLine(XoRFunction(true, false));
        }
    }
}
  