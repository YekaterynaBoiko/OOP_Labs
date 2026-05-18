using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task3
{
    public class Dice
    {
        protected static Random random = new Random();
        public virtual int ThrowDice()
        {
            return 0;
        }
    }
}
// додати три методи, працювати все в одному класі
// зробити перевантаження методів