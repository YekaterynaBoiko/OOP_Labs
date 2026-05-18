using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task3
{
    public class SeveralOfSameDice : CustomDice
    {
        private int _count;
        public SeveralOfSameDice(int count, int side) : base(side)
        {
            this._count = count;
        }

        public override int ThrowDice()
        {
            int sum = 0; 
            for (int i = 0; i < _count; i++)
            {
                int result = random.Next(1, Side + 1);
                Console.WriteLine(result);
                sum += result;
            }

            return sum;
        }
    }
}
