namespace Lab29_Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Storage<User> userStorage = new Storage<User>();
            userStorage.Add(new User(1, "Bob"));
            userStorage.Add(new User(2, "Til"));

            User user = userStorage.GetById(1);
            Console.WriteLine(user);

            Storage<Product> productStorage = new Storage<Product>();
            productStorage.Add(new Product(1, "Laptop"));
            productStorage.Add(new Product(2, "Phone"));
            Product product = productStorage.GetById(1);
            Console.WriteLine(product);

        }
    }
}
