using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task5
{
    public class OnlineOrder : Order
    {
        public string Address
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Адреса обов'язкова!");
                field = value;
            }
        }

        public int ShippingCost { get; set; }

        public OnlineOrder()
        {
        }

        public OnlineOrder(string identifier) : base(identifier)
        {
        }
        public OnlineOrder(string identifier, string name, int basePrice, string address, int shippingCoust) : base(identifier, name, basePrice)
        {
            Address = address;
            ShippingCost = shippingCoust;
        }

        public void ShowInfo()
        {
            PrintInfo();
            Console.WriteLine($"Додаткова інформація: \nАдреса доставки: {Address} \nВартість доставки:{ShippingCost}");
        }
    }
}
