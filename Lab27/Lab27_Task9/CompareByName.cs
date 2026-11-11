using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task9
{
    public static class CompareByName
    {
        public static int CompareName(StreamingService s1, StreamingService s2, int result)
        {
            if (result == 0)
                return s1.Name.CompareTo(s2.Name);

            return result;
        }
    }
}
