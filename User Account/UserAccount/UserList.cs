using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccount
{
    public class UserList
    {
        private List<User> usersList;
        private UserList userList = new UserList();
        private User user;

        public UserList()
        {
            this.usersList = new List<User>();
        }

        public List<User> getUsersList()
        {
            return this.usersList;
        }

        public void addUsersList(User user)
        {
            this.usersList.Add(user);
        }

        //public List<User> getUsersList()
        //{
        //    return this.usersList;
        //}
    }
}
