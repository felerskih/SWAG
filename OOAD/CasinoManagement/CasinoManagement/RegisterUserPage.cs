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
    public partial class RegisterUserPage : Form
    {
        Form ret;
        public RegisterUserPage()
        {
            InitializeComponent();
        }

        public RegisterUserPage(Form frm, bool isManager)
        {

            InitializeComponent();
            if (isManager)
            {
                pnlManageRegis.Visible = true;
                pnlGamblerRegis.Visible = false;
            }
            ret = frm;
        }


        private void RegisterUserPage_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ret.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CasinoManagement.LoginPage log = new LoginPage();
            this.Close();
            log.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string line;
            string[] values;
            bool valid = false;
            using (StreamReader str = new StreamReader("users.txt"))
            {
                line = str.ReadLine();
                while (line != null && !valid)
                {
                    values = line.Split(' ');
                    values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                    if (values[0] == textBox1.Text)
                        valid = true;
                    line = str.ReadLine();
                }
                if (line != "" && valid)
                    MessageBox.Show("Invalid Username! Username already exists!");
            }

            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    //Gambler newGam = new Gambler(textBox1.Text, textBox2.Text);
                    if (!valid)
                    {
                        StreamWriter str = File.AppendText("users.txt");
                        str.WriteLine("\n" + textBox1.Text + " " + textBox2.Text + " " + 0 + " " + "0.0");
                        str.Close();
                        LoginPage log = new LoginPage();
                        log.Show();
                        this.Close();
                    }

                }
                else
                    MessageBox.Show("Please enter a password!");
            }
            else
                MessageBox.Show("Please enter a username!");
        }
    }
}
