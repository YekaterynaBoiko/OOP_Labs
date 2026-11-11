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
        public int ThrowDice()
        {
            return random.Next(1, 7);
        }

        public int ThrowDice(int side)
        {
            return random.Next(1, side + 1);
        }

        public int ThrowDice(int side, int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
                sum += random.Next(1, side + 1);

            return sum;
        }
    }
}
// додати три методи, працювати все в одному класі
// зробити перевантаження методів