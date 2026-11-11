namespace Lab28_Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            OrderSystem orderSystem = new OrderSystem();
            orderSystem.AddProduct(new Product("Laptop", 50000, 5));
            orderSystem.AddProduct(new Product("TV", 45000, 3));

            var orders = new (string name, int quantity)[]
            {
                ("Laptop", 2),
                ("Apple", 1),
                ("TV", 0),
                ("TV", 4)
            };

            foreach (var order in orders)
            {
                try
                {
                    Console.WriteLine($"\nОбробка замовлення: " +
                        $"\nНазва: {order.name} " +
                        $"\nКількість: {order.quantity}");
                    orderSystem.OrderProcessing(order.name, order.quantity);
                }
                catch (ProductNotFoundException ex)
                {
                    Console.WriteLine("Товар відсутній");
                    Console.WriteLine(ex.Message);
                }
                catch (BaseException ex)
                {
                    Console.WriteLine("Загальна помилка");
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
