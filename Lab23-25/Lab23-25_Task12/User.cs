using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    public class User : Person
    {
        public decimal Balance { get; set; }
        public List<Request> Requests { get; set; } = new List<Request>();
        public User(string name, string login, string password, decimal balance) : base (name, login, password)
        {
            Balance = balance;
        }

        public void Submit(RealEstate realEstate)
        {
            if (realEstate.IsSold || realEstate.isBlocked)
            {
                Console.WriteLine("Об'єкт вже проданий або заблокований");
                return;
            }
            decimal required = realEstate.RequiredBudget();
            if (Balance < required)
            {
                Console.WriteLine($"Відмова через нестачу коштів. На балансі: {Balance} " +
                    $"\nСума яка потрібна для покупки: {required}");
                return;
            }
            Request request = new Request(this, realEstate);
            realEstate.Block();
            Requests.Add(request);

            Console.WriteLine("Заявку створено");
        }

        public override void Role()
        {
            Console.WriteLine("User");
        }
    }
}
