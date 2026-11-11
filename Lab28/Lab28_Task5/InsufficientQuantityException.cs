using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task5
{
    public class InsufficientQuantityException : BaseException
    {
        public int Available { get; }
        public int Requested { get; }
        public string ProductName { get;  }
        public InsufficientQuantityException(int available, int requested, string productName) 
            : base($"\nНедостатня кількість {productName} на складі: " +
                  $"\nЗапит на покупку: {requested} " +
                  $"\nДоступно в магазині: {available}")
        {
            Available = available;
            Requested = requested;
            ProductName = productName;

        }
    } 
}
