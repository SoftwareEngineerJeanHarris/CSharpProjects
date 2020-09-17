using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount
{
    public class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            setUsername(username);
            setPassword(password);
        }

        public string getUsername()
        {
            return this.username;
        }

        public string getPassword()
        {
            return this.password;
        }

        public void setUsername(string username)
        {
            this.username = username;
            Console.WriteLine("Added user: " + username);
        }

        public void setPassword(string password)
        {
            this.password = password;
            Console.WriteLine("Added password: " + password);
        }
    }
}
