using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.IO;

namespace UserAccount
{
    public partial class userAccountsWindow : Form
    {
        public userAccountsWindow()
        {
            InitializeComponent();
        }

        private void userAccountsWindow_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Switch to Create account window.
            panelRight.Left = 20;
            errorLabel.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Switch to Login window.
            panelRight.Left = 368;
            errorLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rootFolder = "C:/Users/godil/Desktop/Programming/C#/User Account/UserAccount/";
            //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
            string textFile = "C:/Users/godil/Desktop/Programming/C#/User Account/UserAccount/UsersAndPasswords.txt";

            if (File.Exists(textFile))
            {
                String username = "";
                String password = "";

                // Read entire text file content in one string    
                //string text = File.ReadAllText(textFile);
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                {
                    string[] words = line.Split(' ');

                    for (int i=0; i<2; i++)
                    {
                        if (i == 0)
                        {
                            username = words[i];
                        }
                        else
                        {
                            password = words[i];
                        }
                    }
                    //Login
                    if (textBox1.Text == username && textBox2.Text == password)
                    {
                        errorLabel.Text = "";
                        MessageBox.Show("Logging in.");
                        User user1 = new User("testUser", "testPassword");
                        Console.WriteLine("Logging in as; Username: " + user1.getUsername() + ". Password: " + user1.getPassword());
                    }
                    else
                    {
                        errorLabel.Text = "Incorrect login details";
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //If both fields are filled, Obbject is created and printed out to the console.
            if (textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "")
            {
                User user = new User(textBox3.Text, textBox4.Text);
                //UserList userList = new UserList();
                //userList.addUsersList(user);
                errorLabel.Text = "";
                
                string path = @"C:/Users/godil/Desktop/Programming/C#/User Account/UserAccount/UsersAndPasswords.txt";
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("");
                    sw.Write(textBox3.Text);
                    sw.Write(" " + textBox4.Text);
                    sw.Write(" " + textBox5.Text);
                    sw.Write(" " + textBox6.Text);
                }

            }
            else
            {
                errorLabel.Text = "Provide valid input";
            }
        }
    }
}
