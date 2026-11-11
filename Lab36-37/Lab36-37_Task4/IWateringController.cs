using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab36_37_Task4
{
    public interface IWateringController
    {
        public int ReadSoilMoisture();
        public void OpenValve();
        public void CloseValve();
    }
}