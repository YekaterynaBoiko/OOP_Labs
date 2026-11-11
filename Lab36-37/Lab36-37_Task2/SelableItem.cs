using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab36_37_Task2
{
    public class SelableItem : GameItem
    {
        /// <summary>
        /// Ціна предмета в золотих монетах.
        /// </summary>
        public int Price { get; }

        public SelableItem(string name, int price) : base(name)
        {
            Price = price;
        }

        /// <summary>
        /// Продає предмет торговцю.
        /// </summary>
        /// <returns>Кількість отриманих золотих монет.</returns>
        public int Sell()
        {
            Console.WriteLine($"Продано предмет «{Name}» за {Price} золотих");
            return Price;
        }
    }
}
