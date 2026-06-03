using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    
    public class Request
    {
        private static int _counter = 1;
        public int Number { get; }
        public User Buyer { get; }
        public RealEstate RealEstate { get;  }

        public bool? isApproved { get; private set; }
        public string RejectReason { get; private set; }

        public Request(User buyer, RealEstate realEstate)
        {
            Number = _counter++;
            Buyer = buyer;
            RealEstate = realEstate;

            isApproved = null;
        }

        public void Approve()
        {
            if (isApproved != null)
            {
                Console.WriteLine("Ваша заявка вже оброблена");
                return;
            }

            Buyer.Balance -= RealEstate.Price;
            RealEstate.Sell();

            decimal commission = RealEstate.CalculateCommission();
            Console.WriteLine($"Комісія агенства: {commission}");
            isApproved = true;
        }

        public void Reject(string reason)
        {
            if (isApproved != null)
            {
                Console.WriteLine("Ваша заявка вже оброблена");
                return;
            }
            RejectReason = reason;

            RealEstate.MakeAvailable(); // робить об'єкт доступним 

            isApproved = false;

            Console.WriteLine($"Причина: {reason}");
        }
    }
}
