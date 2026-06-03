using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task2
{
    public class Euro : Currency
    {
        public override decimal ExchangeRate => 51.0m;
        public override decimal Convert(decimal hryvnias)
        {
            return hryvnias / ExchangeRate;
        }
        public override string CurrencyCode => "EUR";
    } 
} 
