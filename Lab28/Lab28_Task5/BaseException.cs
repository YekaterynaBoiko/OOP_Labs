using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28_Task5
{
    public class BaseException : Exception
    {
        public BaseException(string message) : base(message) { }
    }
}
