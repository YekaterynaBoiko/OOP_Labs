using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_Task4
{
    public class Address // незалежний клас, від нього залежать
    {
        public string City;
        public string Street;
        public int House;

        public Address(string city, string street, int house)
        {
            City = city;
            Street = street;
            House = house;
        }

        public override string ToString()
        {
            return $"{City}, {Street}, {House}";
        }
    }
}