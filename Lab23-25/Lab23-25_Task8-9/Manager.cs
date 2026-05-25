using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task8_9
{
    public class Manager
    {
        public void AssingTask(Employee employee)
        {
            if (employee is Programmer programmer)
                programmer.WriteCode();

            if (employee is Designer designer)
                designer.DrawMockup();
        }

    }
}
