using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab26_Task1
{
    public class Deer : Herbivorous
    {
        public override string Name => "Deer";
        public override void MakeSound()
        {
            Console.WriteLine("Я олень");
        }
        public override void Action()
        {
            Console.WriteLine("Полює на вовка");
        }
    }
}
