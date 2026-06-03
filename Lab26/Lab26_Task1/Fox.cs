using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task1
{
    public class Fox : Predators
    {
        public override string Name
            => "Fox";
        public override void MakeSound()
        {
            Console.WriteLine("Fox");
        }
        public override void Action()
        {
            Console.WriteLine("Лякає оленя");
        }
    }
}
