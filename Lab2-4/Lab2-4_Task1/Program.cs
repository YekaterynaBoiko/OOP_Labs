namespace Lab2_4_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
                
            }
            else if (a < b) 
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Числа рівна");
            }
        }
    }
}
