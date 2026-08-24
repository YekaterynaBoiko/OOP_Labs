namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine()); // 6 != 0 => 9 = n 
            //int sum = 0;
            //while (n != 0) // 5 
            //{
            //    sum += n;
            //    n = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine(sum);


            int n;
            int sum = 0;
            while ((n = Convert.ToInt32(Console.ReadLine())) != 0)  { sum += n; } // 1- інструкція, 2 - вираз результатом є значення користувача, 3 - 
            Console.WriteLine(sum);
            //(n = Convert.ToInt32(Console.ReadLine())) інструкція та вираз вираз одночасно
        }
    }
}
