using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task1
{
    public class Hare : Herbivorous
    {
        public override string Name => "Hare";
        public override void MakeSound()
        {
            Console.WriteLine("Hare");
        }
        public override void Action()
        {
            Console.WriteLine("Їсть траву, ховається від вовка");
        }
    }
}
