using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccount;

namespace UserAccount
{
    static class Program
    {
        ///
        /// The main entry point for the application.
        ///
        [STAThread]
        static void Main()
        {
            //List<User> usersList = new List<User>();

            //User user1 = new User("testUser", "testPassword");
            //User user1 = new User("testUser", "testPassword");
            //usersList.Add(new User("testList1", "testList1"));
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("--------------------Adding User------------------------");
            //UserList userList = new UserList();
            //userList.addUsersList("first user","password");
            //foreach (var item in userList.getUsersList())
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(userList.getUsersList());

            /*
            User user1 = new User("testUser", "testPassword");
            
            private userAccountsWindow a;
            public Program(userAccountsWindow a)
            {
                this.a = a;
            }

            foreach (var item in usersList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("1) Username: " + user1.getUsername() + ". Password: " + user1.getPassword());
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new userAccountsWindow());
        }
    }
}
