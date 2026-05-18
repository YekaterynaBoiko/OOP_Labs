namespace Lab22_Task2
{
    public  class Program
    {

        public static void Print(params Object[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                Console.Write(obj[i]);

                if (i < obj.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Print(1, 2);
            Print("a", 'b');
            Print(1, "a");
            Print(true, "a", 1);

        }
    }
}
