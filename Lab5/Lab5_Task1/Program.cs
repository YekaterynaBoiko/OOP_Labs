namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= n; i++) // i = 1, 2, 2, 3, 3,.....
            {// те що вводимо number номер ітерації
                for (int j = 1; j <= i; j++)
                {
                    count++;
                    if (count > n) 
                    {
                        return; // break - зупиняє лише внутр цикл; return - зупиняє всі цикли
                    }
                    Console.Write($"{i} ");
                }
            }
    }   } //5 => 1, 2, 2, 3, 3
}
