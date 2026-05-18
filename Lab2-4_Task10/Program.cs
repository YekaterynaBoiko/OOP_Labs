using System.Collections.Specialized;

namespace Lab2_4_Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while(явна умова)
            int n;
            double average = 0;
            int sum = 0;
            int count = 0;
            while ((n = Convert.ToInt32(Console.ReadLine())) >= 0 && n <= 10) //від 0 до 10
            {
                sum += n;
                count++;
                
            }
            if (count > 0) Console.WriteLine(average = sum / count);
            // 1 2 3 -1 s
            // 1 2 3 4 11 => average 1+2+3+4/5 = 2
        }
    }
}
