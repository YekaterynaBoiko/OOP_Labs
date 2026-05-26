using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task12
{
    public class Admin : Person
    {
        public Admin(string name, string login, string password)
            : base(name, login, password) { }

        public void ApproveApplication(Request request)
        {
            request.Approve();
        }

        public void RejectApplication(Request request, string reason)
        {
            request.Reject(reason);
        }
        public override string Role
        {
            get { return "Admin"; }
        }
    }
}
