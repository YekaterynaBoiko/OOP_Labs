namespace Lab2_4_Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            do
            {
                int n = Convert.ToInt32(Console.ReadLine());
                sum += n; //число до суми
                count++;
            }

            while (sum % 2 != 0); 
            Console.WriteLine(count % 2 == 0); // к-сть парна чи нє

        }
    }
}
