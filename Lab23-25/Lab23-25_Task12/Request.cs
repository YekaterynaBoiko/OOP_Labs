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
        public User Buyer { get;  }
        public RealEstate RealEstate { get;  }

        public bool isApproved { get; private set; }
        public bool isProcessed { get; private set; }
        public string RejectReason { get; private set; }

        public Request(User buyer, RealEstate realEstate)
        {
            Number = _counter++;
            Buyer = buyer;
            RealEstate = realEstate;

            isApproved = false;
            isProcessed = false;
        }

        public void Approve()
        {
            if (isProcessed)
            {
                Console.WriteLine("Ваша заявка вже оброблена");
                return;
            }

            if (Buyer.Balance >= RealEstate.Price)
            {
                Buyer.Balance -= RealEstate.Price;
                RealEstate.Sell();

                decimal commission = RealEstate.CalculateCommission();
                Console.WriteLine($"Комісія агенства: {commission}");
                isApproved = true;
                isProcessed = true;
            }
            else
                Console.WriteLine("На вашому рахунку недостатньо коштів");
        }

        public void Reject(string reason)
        {
            if (isProcessed)
            {
                Console.WriteLine("Ваша заявка вже оброблена");
                return;
            }
            RejectReason = reason;

            RealEstate.MakeAvailable(); // робить об'єкт доступним 

            isApproved = false;
            isProcessed = true;

            Console.WriteLine($"Причина: {reason}");
        }
    }
}
