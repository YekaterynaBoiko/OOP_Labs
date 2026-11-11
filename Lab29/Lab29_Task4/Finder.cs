using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task4
{
    public static class Finder
    {
        public static T MaxFinder<T>(IEnumerable<T> values)
            where T : IComparable<T>
        {
            T max = default;
            bool hasValue = false;

            foreach (T value in values)
            {
                if (!hasValue || value.CompareTo(max) > 0)  
                {
                    max = value;
                    hasValue = true;
                }
            }
            if (!hasValue)
                throw new InvalidOperationException("List is empty"); 

            return max;
        }
    }
}
