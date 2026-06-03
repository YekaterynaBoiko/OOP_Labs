using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task1
{
    public class Wolf : Predators
    {
        public override string Name
            => "Wolf";

        public override void MakeSound()
        {
            Console.WriteLine("yyyy");
        }
        public override void Action()
        {
            Console.WriteLine("Їсть зайця");
        }
    }
}
