using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_40_Task3
{
    public class XmlBookImporter : BookImporter
    {

        public override IBookParser CreateParser()
        {
            return new XmlBookParser();
        }
    }
}