using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task1
{
    public class ClassDescription
    {
        public string Name { get; set; }
        private readonly List<Field> _fields; // лінива ініціалізація(перше присвоєння) = щоб в поле нічого не писалося
        private const string Indent = "  ";

        public ClassDescription(string name)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name);

            Name = name;
            _fields = new();
        }

        public void AddField(Field field)
        {
            _fields.Add(field);
        }
        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"public class {Name}");
            stringBuilder.AppendLine("{");

            foreach (Field field in _fields)
            {
                stringBuilder.AppendLine(Indent + field.ToString());
                
            }
            stringBuilder.AppendLine("}");

            return stringBuilder.ToString();
        }
    }
}