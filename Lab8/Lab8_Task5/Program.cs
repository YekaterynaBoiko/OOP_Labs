namespace Lab8_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[][] lines = new string[n][]; //зубчастий всі рядки
            string?[] line;//один рядок
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine().Split();
                lines[i] = line; //записуємо рядок на однаковий індекс зубчастого масиву 
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", lines[i]));
            }
            foreach (string[] row in lines)
            {
                foreach (string col in row)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }
    }
}
