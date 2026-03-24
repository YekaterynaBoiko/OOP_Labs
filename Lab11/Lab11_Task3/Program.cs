namespace Lab11_Task3
{
    internal class Program
    {

        public class Student
        {
            public string Name, Surname;
            public int[] Marks = new int[3];

            public decimal ArithmeticMean()
            {
                decimal result = 0m;
                for (int i = 0; i < Marks.Length; i++)
                {
                    result += Marks[i];
                }
                return result /= Marks.Length;
            }
        }
        static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = new Student();    
                students[i].Name = Console.ReadLine();
                students[i].Surname = Console.ReadLine();
                string[] marks = Console.ReadLine().Split(' ');
                for (int j = 0; j < 3; j++)
                {
                    students[i].Marks[j] = Convert.ToInt32(marks[j]);
                }
            }

            decimal maxResult = students[0].ArithmeticMean();
            for (int i = 1; i < students.Length; i++)
            {
                decimal average = students[i].ArithmeticMean();
                if (average > maxResult)
                {
                    maxResult = average;
                }
            }
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].ArithmeticMean() == maxResult) Console.WriteLine($"{students[i].Name} {students[i].Surname}");
            }
        }
    }
}
//Student student1 = new Student();
//Student student2 = new Student();

//student1.Marks = new int[] {1, 1, 1}; 
//student2.Marks = new int[] { 5, 5, 5 };
//if (student1.ArithmeticMean() > student2.ArithmeticMean())
//{
//    student1.ArithmeticMean();
//}
//else student2.ArithmeticMean();
