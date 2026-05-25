using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    public class Person
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; private set; }

        public Person(string name, string login, string password)
        {
            Name = name;
            Login = login;
            Password = password;
        }

        public virtual void Role()
        {
            Console.WriteLine("Person");
        }
    }
}
