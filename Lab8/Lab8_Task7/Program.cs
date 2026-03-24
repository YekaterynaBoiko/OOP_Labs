namespace Lab8_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            int row = 0;
            int col = 0;
            while ((line = Console.ReadLine()) != null)
            {
                row++; //к-сть рядків
                if (row == 1) // рахує лише для першогог рядка для решти рахувати не буде 
                col = line.Split().Length;
            }
            Console.WriteLine($"Рядків: {row}");
            Console.WriteLine($"Cтовпців: {col}");
        }
    }
}
