using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK6_LiveCoding 
{
    public class PopMusic :MusicComposition
    {
        public PopMusic(string title, string author, TimeSpan duration)
            : base(title, author, duration) { }
        public override string Genre => "Pop";

    }
}
