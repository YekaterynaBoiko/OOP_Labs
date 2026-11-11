using System.Collections.Specialized;

namespace MK3_Task4
{
    internal class Program
    {

        public class WritingMaterials
        {
            public string Name, Color;
            public int Price; 
            public double Length;
            public bool Draw;

            public WritingMaterials(string name, string color, int price, double length, bool draw)
            {
                Name = name;
                Color = color;
                Price = price;
                Length = length;
                Draw = draw;
            }

            public void Display()
            {
                string DrawAnswer;
                if (Draw)
                    DrawAnswer = "Так";
                else
                    DrawAnswer = "Ні";
                Console.WriteLine($"\nНазва: {Name} \nКолір: {Color} \nДовжина: {Length} \nЦіна: {Price} \nВміє малювати: {DrawAnswer}");
            }

            public void Replace_Rod(string newColor)
            {
                Color = newColor;
            }

            public void PriceUp(int amount)
            {
                Price += amount;
            }

            public void PriceDown(int amount)
            {
                Price -= amount;
            }

            public void DrawOrNot()
            {
                if (Draw)
                    Console.WriteLine($"{Name} провів лінію. Її колір - {Color}");
                else
                    Console.WriteLine($"{Name} не може нічого намалювати");
            }
        }
        static void Main(string[] args)
        {
            WritingMaterials material1 = new WritingMaterials("Олівець", "Сірий", 15, 12.5, true);
            material1.Display();
            Console.WriteLine("Напишіть колір на який ви хочете замінити: ");
            string color = Console.ReadLine();
            material1.Replace_Rod(color);
            material1.PriceUp(3);
            material1.Display();
            material1.DrawOrNot();
        }
    }
}
