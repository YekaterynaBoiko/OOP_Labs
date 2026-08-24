using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task9
{
    public class SortingByDuration : IComparer<StreamingService>
    {
        public int Compare(StreamingService s1, StreamingService s2)
        {
            int result = s1.Duration.CompareTo(s2.Duration);
            return CompareByName.CompareName(s1, s2, result);
        }
    }
}
