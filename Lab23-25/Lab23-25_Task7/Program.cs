namespace Lab23_25_Task7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address(34478, "Ужгород", "вул. Інженерна", 15, 12);
            Address address1 = Address.CreateObject("Ужгород, вул. Інженерна, 15, кв. 12");
            Address address2 = Address.CreateObject("04138 Київ, просп. Перемоги, 35");
            Console.WriteLine(address);
            Console.WriteLine(address1);
            Console.WriteLine(address2);

            Console.WriteLine(Address.AddressCompare(address1, address2));
            Console.WriteLine(Address.AddressCompare(address, address1));
        }
    }
}

