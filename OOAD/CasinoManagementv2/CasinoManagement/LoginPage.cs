using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CasinoManagement
{
    public partial class LoginPage : Form
    {
        ManageLogin logM = new ManageLogin();
        ManagerPage pageManager = new ManagerPage();
        GamblerPage pageGambler = new GamblerPage();
        DealerPage pageDealer = new DealerPage();
        RegisterUserPage regUser = new RegisterUserPage();

        public User[] users = new User[100];
        public int accountCount = 0;

        public LoginPage()
        {
            InitializeComponent();
            string line;
            string[] values;
            try
            {
                using (StreamReader str = new StreamReader("users.txt"))
                {
                    line = str.ReadLine();
                    values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                    while (line != null)
                    {
                        values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                        if (values[2] == "0")
                        {
                            users[accountCount] = new Gambler(values[0], values[1], 0, float.Parse(values[3]));
                            accountCount++;
                        }
                        else if (values[2] == "1")
                        {
                            users[accountCount] = new Dealer(values[0], values[1], 1);
                            accountCount++;
                        }
                        else if (values[2] == "2")
                        {
                            users[accountCount] = new Manager(values[0], values[1], 2);
                            accountCount++;
                        }
                        line = str.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot find file " + ex);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validName = false;
            for (int i = 0; i < accountCount; i++)
            {
                if (users[i].getName() == txtUsername.Text && users[i].getPass() == txtPassword.Text)
                {
                    validName = true;
                    this.Hide();
                    int type = users[i].getType();
                    if (type == 0)
                    {
                        pageGambler = new GamblerPage(this, users[i]);
                        pageGambler.Show();
                    }
                    else if (type == 1)
                    {
                        pageDealer = new DealerPage(this, users[i]);
                        pageDealer.Show();
                    }
                    else if (type == 2)
                    {
                        pageManager = new ManagerPage(this, users[i]);
                        pageManager.Show();
                    }
                }
            }
            if (validName == false)
                MessageBox.Show("Username or Password is incorrect.");
        }
            /*
            string line;
            string[] values;
            try
            {
                using (StreamReader str = new StreamReader("users.txt"))
                {
                    line = str.ReadLine();
                    values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                    while (line != null && values[0] != txtUsername.Text)
                    {
                        values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                        line = str.ReadLine();            
                    }
                    if (values[0] == txtUsername.Text && values[1] == txtPassword.Text)
                    {
                        //go to new form and make new user
                        this.Hide();
                        if (values[2] == "0")
                        {
                            pageGambler = new GamblerPage(this, values[0], values[1], values[3]);
                            pageGambler.Show();
                        }                          
                        if (values[2] == "1")
                        {
                            pageDealer = new DealerPage(this, values[0], values[1]);
                            pageDealer.Show();
                        }     
                        if (values[2] == "2")
                        {
                            pageManager = new ManagerPage(this, values[0], values[1]);
                            pageManager.Show();
                        }                        
                    }
                    else
                        MessageBox.Show("Username or Password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You fucked up Henry " + ex);
            }
            */


        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            regUser.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            

        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] lines = new string[100];
            int numLines = 0;
            string[] values;
            try
            {
                using (StreamReader sr = new StreamReader("users.txt"))
                {
                    while ((lines[numLines] = sr.ReadLine()) != null)
                        numLines++;
                }
                using (StreamWriter sw = new StreamWriter("users.txt"))
                {
                    for(int i = 0; i < numLines-1; i++)
                    {
                        //values = lines[i].Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                        if (users[i].getType() == 0)
                        {
                            Gambler g = (Gambler)users[i];
                            lines[i] = users[i].getName() + " " + users[i].getPass() + " " + users[i].getType() + " " + g.GetFunds();
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            Application.Exit();
        }
    }
}
