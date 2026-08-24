using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task1
{
    public abstract class Transport
    {
        public int Speed { get; set; }
        public string Model { get; set; }
        protected Transport(int speed, string model)
        {
            Speed = speed;
            Model = model;
        }
        public abstract void Move();
    }
}
