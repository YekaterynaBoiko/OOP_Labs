namespace Lab27_Task6
{
    public class Program 
    {
        public static IComparable MiddleOfThree(IComparable a, IComparable b, IComparable c)
        {
            if(a.CompareTo(b) > 0)
            {
                if (b.CompareTo(c) > 0)
                {
                    return b;
                }
                    
                else if (a.CompareTo(c) > 0)
                {
                    return c;
                }
                else
                {
                    return a;
                }
            }
            else 
            {
                if (a.CompareTo(c) > 0)
                {
                    return a;
                }
                else if (b.CompareTo(c) > 0)
                {
                    return c;
                }
                else
                {
                    return b;
                }
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleOfThree(2, 5, 4));
            Console.WriteLine(MiddleOfThree(3, 1, 2));
            Console.WriteLine(MiddleOfThree(3, 5, 9));
            Console.WriteLine(MiddleOfThree("B", "Z", "A"));
            Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
        }
    }
}
