using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task3
{
    public class Cylinder : Circle
    {
        public double Height { get; set; }

        public Cylinder(double radius, double height) : base(radius)
        {
            if (height < 0)
                Height = 0;
            else
                Height = height;
        }

        public double GetVolume()
        {
            return GetArea() * Height;
        }
    }
}
