using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task2
{
    public abstract class Currency
    {
        public abstract decimal ExchangeRate { get; }
        public abstract decimal Convert(decimal hryvnias);
        public abstract string CurrencyCode { get; }
    }
}
