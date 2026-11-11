namespace Lab26_Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            new BicycleCourier("Петров Іван", "Максим", 2.5, 10);
            new AutoCourier("Анна", "Ігор", 5, 20);
            new TruckDelivery("ТОВ Рошен", "ТОВ Амазон", 100, 1000);
            new ExpressDelivery("Петро", "Катерина", 3, 200);

            Console.WriteLine("Усі доставки: ");
            DeliveryJournal.PrintAllInfo();

            Console.WriteLine($"\nЗагальна кількість замовлень: {DeliveryJournal.Count}" +
                $"\nВиручка компанії: {DeliveryJournal.TotalRevenue()}");
        }
    }
} 
