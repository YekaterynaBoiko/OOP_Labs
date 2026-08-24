using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_Task9
{
    public class BestRated : IComparer<StreamingService> 
    {
        public int Compare(StreamingService s1, StreamingService s2)
        {
            int result = s1.ViewerRating.CompareTo(s2.ViewerRating);
            return CompareByName.CompareName(s1, s2, result);
        }
    }
}
