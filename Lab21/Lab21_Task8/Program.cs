namespace Lab21_Task8
{
    public class Program
    {
        static void Main(string[] args)
        {
            var journal = new StudentJournal { Name = "КН-124" };
            journal.AddStudent("Yekateryna");
            journal.AddStudent("Sofiia");
            journal.AddStudent("Mariia");

            journal["Yekateryna", 0] = 90;
            journal["Yekateryna", 1] = 93;
            journal["Yekateryna", 2] = 91;

            journal["Sofiia", 0] = 99;
            journal["Sofiia", 1] = 100;
            journal["Sofiia", 2] = 100;

            journal["Mariia", 0] = 93;

            Console.WriteLine(journal["Yekateryna", 1]);
            Console.WriteLine();

            //Console.WriteLine("All info:");
            //Console.WriteLine();
            //journal.ShowAllInfo();
        }
    }
}
