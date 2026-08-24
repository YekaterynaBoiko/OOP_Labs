namespace Lab27_Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            double orderAmount = 2000;
            ICustomer regularCustomer = new RegularCustomer();
            ICustomer vipCustomer = new VipCustomer();

            Console.WriteLine($"\nRegular customer: {regularCustomer.Discount()}" +
                $"\nTotal with discount: {regularCustomer.CalculatePriceWithDiscount(orderAmount)}");

            Console.WriteLine($"\nVIP customer: {vipCustomer.Discount()}" +
                $"\nTotal with discount: {vipCustomer.CalculatePriceWithDiscount(orderAmount)}");
        }
    }
}
