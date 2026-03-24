using System.Reflection.Metadata.Ecma335;
using System.Runtime.Versioning;

namespace MK3_Task1
{
    public class Program
    {
        public class Grade
        {
            public string Subject;
            public int Value;
            static Random random = new Random(); //одна єдина на весь клас

            public Grade(string subject, int value)
            {
                this.Subject = subject;
                if (value >= 1 && value <= 100)
                    this.Value = value;
                else Console.WriteLine("Error");
            }

            public string ToLetterGrade()
            {
                if (Value >= 90 && Value <= 100) return "A";
                else if (Value >= 82 && Value <= 89) return "B";
                else if (Value >= 75 && Value <= 81) return "C";
                else if (Value >= 69 && Value <= 74) return "D";
                else if (Value >= 60 && Value <= 68) return "E";
                else if (Value >= 35 && Value <= 59) return "Fx";
                else return "F";
            }

            public static Grade CreateRandom(string subject)
            {
                int value = random.Next(1, 101);
                return new Grade(subject, value);
            }
        }

        public class Student
        {
            public string FirstName, LastName;
            public List<Grade> Grades;
            static Random random = new Random();

            public Student(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Grades = new List<Grade>();
            }

            public void AddGrade(Grade grade)
            {
                Grades.Add(grade);
            }

            public double GetAverageGrade()
            {
                if (Grades.Count == 0) return 0;
                double average = 0.0;
                foreach (Grade grade in Grades)
                {
                    average += grade.Value;
                }
                return average / Grades.Count;
            }

            public List<Grade> GetGradesAbove(int threshold)
            {
                List<Grade> result = new List<Grade>();
                foreach (var grade in Grades)
                {
                    if (grade.Value >  threshold)
                        result.Add(grade);
                }
                return result;
            }
            public string GetInfo()
            {
                string info = $"Студент: {FirstName} {LastName} \nКількість оцінок: {Grades.Count} \nСередній бал: {GetAverageGrade()} \nОцінки: ";
                foreach (var grade in Grades)
                    info += $"{grade.Subject} ({grade.Value}, {grade.ToLetterGrade()})";
                return info;

            }

            public static Student CreateDemoStudent(string fullName)
            {
                string[] partsOfStudent = fullName.Split(' ');
                string firstName = partsOfStudent[0];
                string lastName;
                if (partsOfStudent.Length > 1)
                    lastName = partsOfStudent[1];
                else
                    lastName = "";

                Student student = new Student(firstName, lastName);
                string[] subjects = { "Вища математика", "Програмування", "Фізика", "Чисельні методи", "Проєкт", "Економіка" };
                int numberOfGrades = random.Next(3, 7);
                for (int i = 0; i < numberOfGrades; i++)
                {
                    string subject = subjects[random.Next(subjects.Length)];
                    Grade grade = Grade.CreateRandom(subject);
                    student.AddGrade(grade);
                }
                return student;
            }
        }


        public Student CreateNewStudent()
        {
            Console.WriteLine("Введіть ім'я: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введіть прізвище: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Студента успішно додано");
            return new Student(firstName, lastName);
        }
        public void AddGradeToStudent(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("Створіть для початку студента");
                return;
            }
            Console.WriteLine("Введіть назву предмету: ");
            string subject = Console.ReadLine();
            Console.WriteLine("Введіть оцінку від 1 до 100: ");
            int value = Convert.ToInt32(Console.ReadLine());
            student.AddGrade(new Grade(subject, value));
            Console.WriteLine("Оцінку додано");
        }

        public void AverageGrade(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("Створіть для початку студента");
                return;
            }
            Console.WriteLine($"Середній бал: {student.GetAverageGrade()}");
        }

        public void ShowGradesAbove(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("Створіть для початку студента");
                return;
            }
            Console.WriteLine("Введіть поріг: ");
            int threshold = Convert.ToInt32(Console.ReadLine());
            var gradesAbove = student.GetGradesAbove(threshold);
            if (gradesAbove.Count == 0)
                Console.WriteLine("Не знайдено оцінок вище порогу");
            else
            {
                Console.WriteLine("Оцінки вище порогу: ");
                foreach (var grade in gradesAbove)
                    Console.WriteLine($"{grade.Subject} ({grade.Value}, {grade.ToLetterGrade()})");
            }
        }
        
        public void ShowAllInfo(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("Створіть для початку студента");
                return;
            }
            Console.WriteLine(student.GetInfo());
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Student student = null;
            while(true)
            {
                Console.WriteLine("\nМеню: \n1. Створити студента(ввести ім'я та прізвище) \n2. Додати оцінку(предмет, значення)"
                    + "\n3. Показати середній бал \n4. Показати всі оцінки вище заданого порогу \n5. Вивести інформацію про студента"
                    + "\n6. Вихід");
                Thread.Sleep(2000);
                Console.WriteLine("Введіть число від 1 до 6 ");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1": student = program.CreateNewStudent();
                        break;
                    case "2": program.AddGradeToStudent(student);
                        break;
                    case "3": program.AverageGrade(student);
                        break;
                    case "4": program.ShowGradesAbove(student);
                        break;
                    case "5": program.ShowAllInfo(student);
                        break;
                    case "6": Console.WriteLine("Вихід");
                        return;
                    default: Console.WriteLine("Невірний вибір");
                        break;

                }
                
            }
        }
    }
}
