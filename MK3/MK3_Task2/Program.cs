namespace MK3_Task2
{
    internal class Program
    {
        public class Student
        {
            public string FirstName, LastName;
            public List<int> Grades;
            // + konstruktor

            public Student(string FirstName, string LastName)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                Grades = new List<int>();
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());   
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] partOfStudent = Console.ReadLine().Split(' ');
                Student student = new Student(partOfStudent[0], partOfStudent[1]);
                for (int j = 2; j < partOfStudent.Length; j++) 
                    student.Grades.Add(Convert.ToInt32(partOfStudent[j]));

                students.Add(student);
            }

            foreach (Student student in students)
            {
                bool isLowGrade = false;
                foreach (int grade in student.Grades)
                {
                    if (grade <= 3)
                    {
                        isLowGrade = true;
                        break;
                    }
                }
                if (!isLowGrade)
                    Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}
