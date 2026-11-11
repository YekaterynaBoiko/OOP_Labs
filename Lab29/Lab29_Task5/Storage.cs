using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task5
{
    public class Storage<T>
        where T : IEntity
    {
        private readonly Dictionary<int, T> _values = new Dictionary<int, T>();
        public void Add(T value)
        {
            if (_values.ContainsKey(value.Id))
                throw new Exception("Such ID already exists"); 

            _values.Add(value.Id, value);
        }

        public T GetById(int id)  
        {
            if (!_values.ContainsKey(id))
                throw new Exception("No object with this ID exists");

            return _values[id];
        }

        public Dictionary<int, T> GetValues()
        {
            return _values;
        }
    }
}
