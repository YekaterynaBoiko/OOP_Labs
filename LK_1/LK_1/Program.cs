namespace LK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5d; // просто 5 скомпілюється як int, так як наступний рядок += 0.5 то результат у нас буде double, тому початкове значення потрібно щоб також було у double
            a += 0.5; 
            Console.WriteLine(a);
        }
    }
}
