namespace MK2_Task5
{
    internal class Program
    {

        static int MaxOfOne(string numbers)
        {
            string[] num = numbers.Split(' ');
            int maxCount = 0;
            int count = 0;
            foreach (string number in num)
            {
                if (number == "1")
                {
                    count++;
                    if (count > maxCount) maxCount = count;
                }
                else if (number == "0") count = 0;
                else return -1;
            }
            return maxCount;
        }
            static void Main(string[] args)
            {
                string numbers = Console.ReadLine();

                int maxOfOne = MaxOfOne(numbers);
                if (maxOfOne >= 0) Console.WriteLine(maxOfOne);

            }
        }
    }

