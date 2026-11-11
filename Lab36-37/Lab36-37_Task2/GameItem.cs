using System;

namespace Lab36_37_Task2
{
    /// <summary>
    /// Предмет у сумці ігрового персонажа.
    /// </summary>
    public class GameItem 
    {
        /// <summary>
        /// Назва предмета.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Створює предмет із вказаною назвою та ціною.
        /// </summary>
        /// <param name="name">Назва предмета.</param>
        public GameItem(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Показує назву предмета під час огляду сумки.
        /// </summary>
        public void Inspect()
        {
            Console.WriteLine($"Предмет «{Name}»");
        }
    }
}
