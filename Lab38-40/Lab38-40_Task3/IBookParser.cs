using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task3
{
    public interface IBookParser
    {
        public List<Book> Parse(string path);
    }
}
