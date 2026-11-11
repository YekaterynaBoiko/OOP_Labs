using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task5
{
    public interface IPrototype
    {
        public string Title { get; set; }
        public int MaxPoints { get; }

        public IPrototype Clone();
        public string GetType();
    }
}