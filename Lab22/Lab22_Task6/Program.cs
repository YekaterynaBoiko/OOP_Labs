namespace Lab22_Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Administrator administrator = new Administrator("11111");
            administrator.Login(false);
            administrator.Login(false);

            administrator.Login(true);
            administrator.Login(false);

            Console.WriteLine(administrator.tokenSession);
        }
    }
}
