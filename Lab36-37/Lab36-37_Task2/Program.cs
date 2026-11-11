using System;
using System.Text;

namespace Lab36_37_Task2
{
    /// <summary>
    /// Головний клас програми для роботи із сумкою ігрового персонажа.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу: наповнює сумку, показує її вміст і продає предмети торговцю.
        /// </summary>
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Inventory inventory = new Inventory();
            inventory.AddItem(new SelableItem("Зілля здоров'я", 50));
            inventory.AddItem(new GameItem("Ключ від вежі"));
            inventory.AddItem(new SelableItem("Сталевий меч", 200));

            Console.WriteLine("Вміст сумки:");
            inventory.InspectAll();

            Console.WriteLine();
            Console.WriteLine("Продаж предметів:");
            int gold = inventory.SellAll();

            Console.WriteLine();
            Console.WriteLine($"Отримано золотих монет: {gold}");

            Console.WriteLine();
            Console.WriteLine("Вміст сумки після продажу:");
            inventory.InspectAll();
        }
    }
}
