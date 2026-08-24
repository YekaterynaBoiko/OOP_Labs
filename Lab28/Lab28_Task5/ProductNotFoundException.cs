using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task5
{
    public class ProductNotFoundException : BaseException
    {
        public string ProductName { get; }
        public ProductNotFoundException(string productName) 
            : base($"Товару {productName} не знайдено в даному каталозі")
        {
            ProductName = productName;
        }
    }
}
