namespace Lab21_Task7
{
    public static class ExtentionExample
    {
        public static int ToInt(this string text)
        {
            return int.Parse(text);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var arg1 = "100500";
            Console.Write(arg1.ToInt() + "42".ToInt()); // 100542 
        }
    }
}
