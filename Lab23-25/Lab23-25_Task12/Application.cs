 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    public class Application
    {
        public User User { get; }
        public RealEstate RealEstate { get; }
        public bool isApproved { get; private set; }
        public bool isRejected { get; private set; }

        public Application(User user, RealEstate realEstate)
        {
            User = user;
            RealEstate = realEstate;
        }

        public void Approve()
        {
            if (isApproved || isRejected)
            {
                Console.WriteLine("Заявка вже була оброблена.");
                return;
            }
            if (RealEstate.IsSold)
            {
                Console.WriteLine("Нерухомість вже продана.");
                return;
            }

            decimal total = RealEstate.RequiredBudget() + RealEstate.CalculateCommission();
            if (User.Balance < total)
            {
                Console.WriteLine("Недостатньо коштів для покупки.");
                return;
            }

            User.Balance -= total;
            RealEstate.Sell();
            isApproved = true;
            isRejected = false;

            Console.WriteLine("Вашу заявку схвалено.");
        }

        public void Reject()
        {
            if (isApproved || isRejected)
            {
                Console.WriteLine("Заявка вже була оброблена.");
                return;
            }
            isRejected = true;
            isApproved = false;
            Console.WriteLine("Вашу заявку відхилено.");
        }
    }
} // окремий метод для схвалення окремий для відхилення, якщо схвалено списує кошти, знімаєм нерухомість з продажу і статус заявки схвалено 
