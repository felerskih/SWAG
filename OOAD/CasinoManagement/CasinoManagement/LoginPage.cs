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
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Exception: " + ex);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            regUser.Show();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            

        }
    }
}
