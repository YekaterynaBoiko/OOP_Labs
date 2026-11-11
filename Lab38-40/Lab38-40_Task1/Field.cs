using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task1
{
    public class Field
    {
        public string Name {get; set;} 
        public string Type { get; set; }
        public Field(string name, string type)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);
            ArgumentException.ThrowIfNullOrWhiteSpace(type);

            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return $"public {Type} {Name};";
        }
    }
}