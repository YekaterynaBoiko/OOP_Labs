using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            //Task2
            //int day  = Convert.ToInt32(Console.ReadLine());
            //int month = Convert.ToInt32(Console.ReadLine());
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{day}:{month}:{year}"); 

            //Task4
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //double d1 = a + b + c;
            //double d2 = a * b * c;
            //double d3 = a + b + c / 3;
            //Console.WriteLine($"{a}+{b}+{c}={d1}");
            //Console.WriteLine($"{a}*{b}*{c}={d2}");
            //Console.WriteLine($"({a}+{b}+{c})/3={(Math.Round(d3,3))}");


            //Task5
            //string name = Convert.ToString(Console.ReadLine());
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{name} {age}");

            //int difference = 100 - age; 
            //int year = 2025 + difference; 
            //Console.WriteLine("The year when a person turns 100: " + year);


            //Task3
            //int x = Convert.ToInt32(Console.ReadLine()); //місячний бюджет на всіх
            //int y = Convert.ToInt32(Console.ReadLine()); //на одного
            ////10000 2400
            //int c = x / y; //максимальна кільстьь розобникв
            //int d = x % y;
            //Console.WriteLine(" " + c);
            //Console.WriteLine(" " + d);

            //Task6
            //int year = Convert.ToInt32(Console.ReadLine());
            //bool isYearLeap = (year % 400 == 0 || year % 100 != 0 && year % 4 == 0); //викосний

            //Console.WriteLine(isYearLeap);

            //Task 7
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //bool isEven = ((a + b) % 2 == 0 && a * b % 2 != 0); //4 + 6 = 0 => true 
            //Console.WriteLine(isEven);

            //float a = (float)6.6; //=> явний кастинг

            //Task8
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());

            //bool isTriangle = ((a + b > c) && (b + c > a) && (c + a > b)); 
            //Console.WriteLine(isTriangle);

            //Task9 спосіб 1
            //string text1 = Convert.ToString(Console.ReadLine());
            //string text2 = Convert.ToString(Console.ReadLine());
            //string text3 = Convert.ToString(Console.ReadLine());
            //bool isTheSame = (text1 == text2) text1 != text3) || (text1 == text3 && text1 != text2) || (text2 == text3 && text2 != text1));
            //bool isTheSame = ((text1 == text2) && text1 != text3) || (text1 == text3 && text1 != text2) || (text2 == text3 && text2 != text1));
            //Console.WriteLine(isTheSame);

            //спосіб 2 з ^
            //string text1 = Console.ReadLine();
            //string text2 = Console.ReadLine();
            //string text3 = Console.ReadLine();
            //bool isTheSame = (text1 == text2) ^ (text1 == text3) ^ (text2 == text3) && !(text1 == text2 && text2 == text3 && text1 == text3);
            //Console.WriteLine(isTheSame);


        }

    }
 }

