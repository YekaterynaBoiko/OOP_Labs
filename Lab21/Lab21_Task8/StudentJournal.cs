using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Task8
{
    public class StudentJournal
    {
        public const int MaxGrade = 5;

        private Dictionary<string, int[]> _journalGrades = new Dictionary<string, int[]>();
        public required string Name
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ім'я не може бути порожнім!");
                field = value;
            }

        }

        
        public int this[string name, int index]
        {
            get
            {
                if (!_journalGrades.ContainsKey(name))
                    throw new ArgumentException("Студента не знайдено!");

                if (index < 0 || index >= MaxGrade)
                    throw new ArgumentException("Невірний індекс!");

                return _journalGrades[name][index];
            }

            set
            {
                if (!_journalGrades.ContainsKey(name))
                    throw new ArgumentException("Студента не знайдено!");

                if (index < 0 || index >= MaxGrade)
                    throw new ArgumentException("Невірний індекс!");

                 _journalGrades[name][index] = value;
            }
        }

        public void AddStudent(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Ім'я не може бути порожнім!");

            if (_journalGrades.ContainsKey(name))
                throw new ArgumentException("Такий студент вже є!");

            _journalGrades[name] = new int[MaxGrade];
        }

        public void ShowAllInfo()
        {
            foreach (var student in _journalGrades)
            {
                Console.WriteLine($"{student.Key}:");

                foreach (var grade in student.Value)
                    Console.WriteLine(grade);

                Console.WriteLine();
            }
        }
        //   індексатор для отримання, додавання без індексатора, вивод оцінок так само прохід по словнику
        // 
    }
}
 