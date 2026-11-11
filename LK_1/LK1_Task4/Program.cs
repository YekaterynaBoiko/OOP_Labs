namespace LK1_Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = Convert.ToDouble(Console.ReadLine());
            //double modul = Math.Abs(Math.Pow(Math.Acos(Math.PI * Math.Pow(x, 3)), 2) - Math.Exp(-Math.Sqrt(Math.Abs(x))));
            //double f = 5 * Math.Pow(Math.Asin(modul), 2);
            //Console.WriteLine(f);
            //


            int n = Convert.ToInt32(Console.ReadLine());
            int min = n;
            for (; ;)
            {
                if (n == 0)
                {
                    break;
                }
                if (n < min) { min = n; }
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(min);
        }
    }
}
