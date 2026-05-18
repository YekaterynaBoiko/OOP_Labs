using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task3
{
    public class StandartDice : Dice
    {
        public override int ThrowDice()
        {
            return random.Next(1, 7);
        }
    }
}
