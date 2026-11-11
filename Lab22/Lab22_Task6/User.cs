using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22_Task6
{
    public class User
    {
        private static Random _random = new Random();
        public int id { get; }
        private string _hashPassword;

        protected int failedAttemptCounter;
        internal string tokenSession;

        public User(string password)
        {
            id = GenerateId();
            _hashPassword = password;
        }
        private static int GenerateId()
        {
            return _random.Next();
        }

        protected internal bool RightsValidation()
        {
            return true;
        }

        private protected void SecurityLogEntry(string text)
        {
            Console.WriteLine(text);
        }
    }
}
