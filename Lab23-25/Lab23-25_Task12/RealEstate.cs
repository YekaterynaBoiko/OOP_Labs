using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    public class RealEstate
    {
        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; private set; }

        public RealEstate(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
            IsSold = false;
        }

        public virtual string Describe()
        {
            return $"ID: {Id} " +
                $"\nНазва: {Name}" +
                $"\nЦіна: {Price}";
        }

        public virtual decimal CalculateCommission()
        {
            return Price * 0.02m;
        }

        public virtual decimal RequiredBudget()
        {
            return Price;
        }

        public void Sell()
        {
            IsSold = true;
        }

        public void MakeAvailable()
        {
            IsSold = false;
        }
    }
}
