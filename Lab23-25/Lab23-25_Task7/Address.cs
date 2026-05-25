using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task7
{
    public class Address
    { // int 
        public int Index { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
        public Address(int index, string city, string street, int houseNumber, int apartmentNumber)
        {
            Index = index;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            ApartmentNumber = apartmentNumber;
        }

        public Address(int index, string city, string street, int houseNumber)
            : this(index, city, street, houseNumber, 0) { }

        public Address(string city, string street, int houseNumber)
            : this(0, city, street, houseNumber, 0) { }

        public static Address CreateObject(string input)
        {
            int index = 0;
            string city = "";
            string street = "";
            int houseNumber = 0;
            int apartmentNumber = 0;

            string[] parts = input.Split(',');
            for (int i = 0; i < parts.Length; i++)
            {
                string p = parts[i].Trim();
                if (i == 0)
                {
                    int CountNum = ExtractDigits(p);
                    if (CountNum >= 10000)
                    {
                        index = CountNum;
                        city = RemoveDigits(p).Trim();
                    }
                    else
                        city = p;
                }
                else if (i == 1)
                    street = p;
                else if (i == 2)
                    houseNumber = ExtractDigits(p);
                else if (i == 3)
                    apartmentNumber = ExtractDigits(p);

            }
            return new Address(index, city, street, houseNumber, apartmentNumber);
        }

        private static int ExtractDigits(string s)
        {
            string result = "";
            foreach (char c in s)
                if (char.IsDigit(c))
                    result += c;

            if (result == "")
                return 0;

            return int.Parse(result);
        }

        private static string RemoveDigits(string s)
        {
            string result = "";
            foreach (char c in s)
                if (!char.IsDigit(c))
                    result += c;

            return result;
        }

        public static string AddressCompare(Address a, Address b)
        {
            string result = "";
            if (a.Index == b.Index && a.Index != 0)
                result += $"{a.Index}";
            if (a.City == b.City && a.City != "")
                result += $"{a.City}";
            if (a.Street == b.Street && a.Street != "")
                result += $"{a.Street}";
            if (a.HouseNumber == b.HouseNumber && a.HouseNumber != 0)
                result += $"{a.HouseNumber}";
            if (a.ApartmentNumber == b.ApartmentNumber && a.ApartmentNumber != 0)
                result += $"{a.ApartmentNumber}";

            if (result == "")
                return "";

            return result.Trim(',', ' ');
        }

        // tostring і запхати перетворення
        public override string ToString()
        {
            string result = "";
            if (Index != 0)
                result += $"{Index}";
            result += $"{Street}, {HouseNumber}";

            if (ApartmentNumber != 0)
                result += $", кв. {ApartmentNumber}";
            result += $", м. {City}";

            return result;
        }
    } 
}
