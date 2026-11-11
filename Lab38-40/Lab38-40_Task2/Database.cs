using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab38_40_Task2
{
    /// <summary>
    /// База даних про населення найбільших міст світу.
    /// Дані завантажуються з текстового файлу cities.txt.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Населення міст: ключ — назва міста, значення — кількість жителів.
        /// </summary>
        private readonly Dictionary<string, int> _cities;
        private static Database _instance;

        /// <summary>
        /// Створює базу та завантажує в неї дані з файлу cities.txt,
        /// що лежить поруч із програмою.
        /// </summary>
        private Database()
        {
            Console.WriteLine("Ініціалізація бази даних...");

            string path = Path.Combine(AppContext.BaseDirectory, "cities.txt");

            _cities = File.ReadAllLines(path)
                .Chunk(2)
                .ToDictionary(
                    pair => pair[0].Trim(),
                    pair => int.Parse(pair[1]));
        }

        /// <summary>
        /// Метод, що перевіряє чи є вже такий створений об'єкт класу Database
        /// </summary>
        public static Database GetInstance()
        {
            if (_instance == null)
                _instance = new Database();

            return _instance;
        }

        /// <summary>
        /// Кількість міст у базі.
        /// </summary>
        public int CityCount
        {
            get { return _cities.Count; }
        }

        /// <summary>
        /// Повертає населення вказаного міста.
        /// </summary>
        /// <param name="city">Назва міста англійською, як у файлі.</param>
        /// <returns>Кількість жителів.</returns>
        public int GetPopulation(string city)
        {
            return _cities[city];
        }
    }
}
