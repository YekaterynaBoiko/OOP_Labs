namespace Lab9_Task7
{
    internal class Program
    {
        static double GetMaxElement1(List<double> list1) //спосіб 1
        {
            list1.Sort();
            return list1[list1.Count - 1];
        }


        static double GetMaxElement2(List<double> list2) //спосіб 2
        {
            double maxElement = list2[0];
            foreach (double element in list2)
            {
                if (element > maxElement)
                {
                    maxElement = element;
                }
            }
            return maxElement;
        }

        static void PrintList(List<double> list)
        {
            foreach (double item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<double> list = new List<double> { 12.5, 4.4, 1.7, 9.1, 0.6, 10.3 };
            double max1 = GetMaxElement1(list);
            PrintList(list);
            Console.WriteLine(max1);
            

            double max2 = GetMaxElement2(list);
            PrintList(list);
            Console.WriteLine(max2);
        } 
    }
}
