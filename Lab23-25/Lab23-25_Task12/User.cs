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
        public User(string name, string login, string password, decimal balance) 
            : base (name, login, password)
        {
            Balance = balance;
        }

        public Request Submit(RealEstate realEstate) //* щоб метод щось повертав, нову заявку правило гарного тону
        {
            if (realEstate.IsSold) //* isBlocked транзакція заблокована прибрати методи
            {
                Console.WriteLine("Об'єкт вже проданий або заблокований");
                return null;
            }
            decimal required = realEstate.RequiredBudget();
            if (Balance < required)
            {
                Console.WriteLine($"Відмова через нестачу коштів. На балансі: {Balance} " +
                    $"\nСума яка потрібна для покупки: {required}");
                return null;
            }
            Request request = new Request(this, realEstate);
            Requests.Add(request);
            //* відмітка що нерухомість продана, викликати Sell
            Console.WriteLine("Заявку створено");

            return request;
        }

        public override string Role
        {
            get { return "User"; } //* зробити як властивість
        }
    }
}
