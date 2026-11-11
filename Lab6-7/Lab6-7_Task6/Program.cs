namespace Lab6_7_Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1,2,3,4,5
            //string? sentence = Console.ReadLine(); // ? чи може зберігатися 
            string?[] array = Console.ReadLine().Split(',');
            foreach (string arrays in array)
            {
                Console.WriteLine(arrays);
            }
        }
    }
}
