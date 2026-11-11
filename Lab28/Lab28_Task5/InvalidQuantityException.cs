using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task5
{
    public class InvalidQuantityException : BaseException
    {
        public int RequestedQuantity { get; }
        public InvalidQuantityException(int requestedQuantity) 
            : base($"Некоректна кількість товару вказана: {requestedQuantity}")
        {
            RequestedQuantity = requestedQuantity;
        }
    }
}
