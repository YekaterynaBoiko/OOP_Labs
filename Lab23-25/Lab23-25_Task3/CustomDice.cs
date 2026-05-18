using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task3
{
    public class CustomDice : Dice
    {
        protected int Side;
        public CustomDice(int side)
        {
            this.Side = side;
        }
        public override int ThrowDice()
        {
            return random.Next(1, Side + 1);
        }
    }
}
