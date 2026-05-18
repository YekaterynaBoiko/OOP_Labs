using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    public class Printer
    {
        public int TonerLevel { get; private set;  } // якщо змінювати всередині класу private set
        public int PagesPrinted { get; private set;  }
        public bool Duplex { get; set; }

        public Printer(int tonerLevel, bool duplex)
        {
            if (tonerLevel > -1 && tonerLevel <= 100) TonerLevel = tonerLevel;
            else tonerLevel = -1;

            Duplex = duplex;
            PagesPrinted = 0;
        }
        
        

        public bool AddToner(int tonerAmount)
        {
            if (tonerAmount > 0 && tonerAmount + TonerLevel <= 100)
            {
                TonerLevel += tonerAmount;
                return true;
            }
            else return false;
        }

        public int PrintPages(int pages)
        {
            if (Duplex) PagesPrinted += pages / 2;
            else PagesPrinted += pages;
            return pages;
        }
    }
}
