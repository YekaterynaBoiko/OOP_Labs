namespace MK2_3
{
    internal class Program
    {// числа порахувати мат сподівання
        static void Main(string[] args)
        {
            Dictionary<int, decimal> tableOfValues = new Dictionary<int, decimal>() // 0.6 0.6=3 0.1 != 1
            { { 100, 0.6m},
              { 1000, 0.3m},
              { 10000, 0.1m}
            };
            decimal sumOfValues = 0.0m;
            foreach (decimal value in tableOfValues.Values)
            {
                sumOfValues += value;
            }
            if (sumOfValues != 1.0m)
            {
                return;
            }
            decimal mathExpectation = 0;
            foreach (var itemKeys in tableOfValues)
            {
                mathExpectation += itemKeys.Key * itemKeys.Value;
            }

            Console.WriteLine(mathExpectation);




            int[] a = { 1, 2, 3 };
            int[] b = a;
            b[0] = 3;
            Console.WriteLine(b);

    }
}
