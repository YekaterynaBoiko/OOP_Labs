using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    public class Apartment : RealEstate
    {
        public int NumberOfRooms { get; set; }
        public Apartment(int id, string name, decimal price, int numberOfRooms) : base(id, name, price)
        {
            NumberOfRooms = numberOfRooms;
        }
        public override decimal CalculateCommission()
        {
            return Price * 0.015m;
        }
    }
}
