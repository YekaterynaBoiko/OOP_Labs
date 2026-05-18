namespace FailedEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            db.ShowUsers();

            List<User> users = db.GetUsers();

            users.RemoveAt(0);

            Console.WriteLine();
            db.ShowUsers();
        }
    }
}
