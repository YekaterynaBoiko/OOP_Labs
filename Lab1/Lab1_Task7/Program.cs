namespace Lab1_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            bool isEven = ((a + b) % 2 == 0 && a * b % 2 != 0); //4 + 6 = 0 => true 
            Console.WriteLine(isEven);
            //float a = (float)6.6; => явний кастинг
        }
    }
}
