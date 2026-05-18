namespace Lab22_Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order("101", "Vasya", 500);
            Order order1 = new Order("102", "Bob");
            order.PrintInfo();
            Console.WriteLine();
            order1.PrintInfo();

            OnlineOrder onlineOrder = new OnlineOrder("1000", "Anna", 300, "Blumen street", 100);
            OnlineOrder onlineOrder1 = new OnlineOrder("109");
            onlineOrder.ShowInfo();
            Console.WriteLine();
            onlineOrder1.ShowInfo();

            StoreOrder store = new StoreOrder("2000", 99734);
            StoreOrder store1 = new StoreOrder("1000", "Anna", 300, 99734, "O");
            store.ShowInfo();
            Console.WriteLine();
            store1.ShowInfo();
        }
    }
}
