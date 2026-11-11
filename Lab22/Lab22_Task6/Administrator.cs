using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task6
{
    public class Administrator : User
    {
        public Administrator(string text) : base(text)
        {
        }

        public void Login(bool isCorrectPassword)
        {
            if (isCorrectPassword)
            {
                tokenSession = "Token Session";
                failedAttemptCounter = 0;
            }
            else
            {
                failedAttemptCounter++;
                if (failedAttemptCounter > 3)
                    SecurityLogEntry("Failed login");
            }
        } 
    }
}
