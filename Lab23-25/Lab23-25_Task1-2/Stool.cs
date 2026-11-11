using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task1_2
{
    public class Stool
    {
        public int Height { get; set; }
        public Quality quality { get; set; }
        public Stool(int height, Quality quality)
        {
            height = Height;
            quality = quality;
        }

        
        public virtual double AmountOfWood
        {
            get
            {
                if (quality == Quality.Low) return 4 * Height + 12;
                else return 5 * Height + 14;
            }
        }

        public virtual double Cost
        {
            get 
            {
                double d = AmountOfWood;
                if (quality == Quality.Low) return d * 2;
                else if (quality == Quality.Average) return d * 3;
                else return d * 4;
            }
        }
    }
}