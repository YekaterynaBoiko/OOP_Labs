using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task5
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"User ID: {Id}" +
                $"\nUser Name: {Name}";
        }
    }
}
