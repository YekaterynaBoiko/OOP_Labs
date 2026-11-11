using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task5
{
    public class StoreOrder : Order
    {
        public int NumberOfStore { get; set; }
        public string SellersName { get; set; }

        public StoreOrder()
        {
        }

        public StoreOrder(string identifier, string name, int basePrice, int numberOfStore, string sellerName) : base(identifier, name, basePrice)
        {
            NumberOfStore = numberOfStore;
            SellersName = sellerName;
        }

        public StoreOrder(string identifier, int numberOfStore) : base(identifier)
        {
            NumberOfStore = numberOfStore;
        }


        public void ShowInfo()
        {
            PrintInfo();
            Console.WriteLine($"\nДодаткова інфрмація: \nНомер магазину: {NumberOfStore} \nІм'я продавця: {SellersName}");
        }
    }
}
