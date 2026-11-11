using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task4
{
    public sealed class JapaneseDishFactory : IDishFactory
    {
        public Soup CreateSoup() => new MisoSoup();
        public MainCourse CreateMainCourse() => new Sushi();
        public Appetizer CreateAppetizer() => new Edamame();
    }
}