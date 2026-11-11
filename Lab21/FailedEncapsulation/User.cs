using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailedEncapsulation
{
    public class User
    {
        public required string Name 
        {
            get => field;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ім'я не може бути порожнім!");
                field = value;
            }
        }

        [SetsRequiredMembers]
        public User(string name)
        {
            Name = name;
        }
    }
}
