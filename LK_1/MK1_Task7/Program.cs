using System;

namespace MK1_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Спосіб 1 ввід у циклі
            //string word;
            //string line = "";

            //while ((word = Console.ReadLine()) != "STOP")
            //{
            //    line += word + " ";
            //}
            //Console.WriteLine();
            //Console.Write($"{line}!");


            //Спосіб 2
            string line = "";
            string word = Console.ReadLine();
            while (word != "STOP")
            {
                line += word + " ";
                word = Console.ReadLine();
                
            }
            Console.WriteLine();
            Console.WriteLine($"{line}!");
        }
    }
}
