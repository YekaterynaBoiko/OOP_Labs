namespace Lab1_Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text1 = Convert.ToString(Console.ReadLine());
            //string text2 = Convert.ToString(Console.ReadLine());
            //string text3 = Convert.ToString(Console.ReadLine());
            //bool isTheSame = (text1 == text2) text1 != text3)  (text1 == text3 && text1 != text2)(text2 == text3 && text2 != text1));
            //bool isTheSame = ((text1 == text2) && text1 != text3)(text1 == text3 && text1 != text2)(text2 == text3 && text2 != text1));
            //Console.WriteLine(isTheSame);

            //спосіб 2 з ^
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            string text3 = Console.ReadLine();
            bool isTheSame = (text1 == text2) ^ (text1 == text3) ^ (text2 == text3) && !(text1 == text2 && text2 == text3 && text1 == text3);
            Console.WriteLine(isTheSame);
        }
    }
}
