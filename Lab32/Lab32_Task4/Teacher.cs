using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_Task4
{
    public class Teacher
    {
        public string Name;
        public Address Address;
        public Teacher(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Адреса викладача {Name}: {Address}";
        }
    }
}
