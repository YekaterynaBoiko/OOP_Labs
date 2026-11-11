using Lab23_25_Task1_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task1_2
{
    public class Chair : Stool
    {
        public int BackrestHeight { get; set; }
        public Chair(int height, Quality quality, int backrestHeight) : base(height, quality)
        {
            backrestHeight = BackrestHeight;
        }
        public override double AmountOfWood
        {
            get
            {
                double d = base.AmountOfWood;
                return d + 2 * BackrestHeight + 5;
            }
        }
    }
}
