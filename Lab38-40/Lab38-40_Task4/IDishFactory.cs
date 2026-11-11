using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task4
{
    public interface IDishFactory
    {
        public Soup CreateSoup();
        public MainCourse CreateMainCourse();
        public Appetizer CreateAppetizer();
    }
}