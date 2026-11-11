using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task4
{
    public sealed class UkrainianDishFactory : IDishFactory
    {
        public Soup CreateSoup() => new Borscht();
        public MainCourse CreateMainCourse() => new Varenyky();
        public Appetizer CreateAppetizer() => new Salo();
    }
}