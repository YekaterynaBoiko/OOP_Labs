using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FailedEncapsulation
{
    public class Database
    {
        private List<User> _users = new List<User>();

        public Database()
        {
            _users.Add(new User("Іван"));
            _users.Add(new User("Петро"));
            _users.Add(new User("Марія"));
            _users.Add(new User("Олена"));
        }

        public void ShowUsers()
        {
            foreach (var user in _users)
            {
                Console.WriteLine(user.Name);
            }
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
        }


        public List<User> GetUsers()
        {
            return new List<User>(_users);
        }
    }
}
