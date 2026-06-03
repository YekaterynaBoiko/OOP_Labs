namespace Lab23_25_Task12
{
    public class Program
    {
        static void Main(string[] args)
        {
            RealEstate apartmemt = new Apartment(1, "Apartment", 1000000, 3);
            RealEstate house = new House(2, "House", 2500000, 10);
            RealEstate office = new CommercialProperty(3, "Office", 200000);

            Admin admin = new Admin("Admin", "admin", "admin");
            User user = new User("Ivan", "ivan", "3333", 50000000);
            user.Submit(apartmemt);
            user.Submit(house);
            user.Submit(office);
            foreach (var request in user.Requests)
                Console.WriteLine($"\nНомер заяки | Об'єкт: {request.Number} " +
                    $"| {request.RealEstate.Name}");

            admin.ApproveApplication(user.Requests[0]);
            admin.ApproveApplication(user.Requests[1]);
            admin.ApproveApplication(user.Requests[2]);

            foreach (var request in user.Requests)
            {
                string status;

                if (request.isApproved == null)
                    status = "На розгляді";
                else if (request.isApproved == true)
                    status = "Схвалено";
                else
                    status = "Відхилено";

                Console.WriteLine($"\nНомер заявки: {request.Number} " +
                    $"\nОб'єкт: {request.RealEstate.Name}" +
                    $"\nУхвалена чи ні: {request.isApproved}" +
                    $"\nПричина: {request.RejectReason}");
            }

            Console.WriteLine($"\nБаланс користувача: {user.Balance}");
        }
    }
}
