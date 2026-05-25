using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task10
{
    public class Phone : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Телефон вмикається");
        }
    }
}
