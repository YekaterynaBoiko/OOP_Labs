using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task5
{
    public class BlanksStorage
    {
        private readonly Dictionary<string, IPrototype> _prototypes;

        public BlanksStorage()
        {
            _prototypes = new Dictionary<string, IPrototype>();
        }

        public void AddBlank(string name, IPrototype type)
        {
            _prototypes.Add(name, type);
        }

        public IPrototype GetByName(string name) => _prototypes[name].Clone();

        public IPrototype GetByType(string type)
        {
            foreach (IPrototype prototype in _prototypes.Values)
            {
                if (prototype.GetType() == type) 
                    return prototype.Clone();
            }

            return null;
        }
    }
}