using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoManagement
{
    public partial class RegisterUserPage : Form
    {
        Form ret;
        LoginPage log;
        bool fromManager;

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
                ManagerPage man = (ManagerPage)frm;
                log = man.ret;
            }
            else
                log = (LoginPage)frm;
            fromManager = isManager;
            ret = frm;
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

        private void lblValid_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool valid = UserIsValid();

            if (txtBoxName.Text == "" || !valid)
                MessageBox.Show("Error!", "Please enter a valid username!");
            else if (txtBoxPass.Text == "")
                MessageBox.Show("Error!", "Please enter a valid password!");
            else
            {
                log.users[log.accountCount++] = new Gambler(txtBoxName.Text, txtBoxPass.Text, 0);
                ret.Show();
                this.Close();
            }
        }

        //Assume user is a Manager. Poses potential issue if attacker escalates privileges.
        private void btnRegisDealer_Click(object sender, EventArgs e)
        {
            bool valid = UserIsValid();

            if (txtBoxName.Text == "" || !valid)
                MessageBox.Show("Error!", "Please enter a valid username!");
            else if (txtBoxPass.Text == "")
                MessageBox.Show("Error!", "Please enter a valid password!");
            else
            {
                log.users[log.accountCount++] = new Dealer(txtBoxName.Text, txtBoxPass.Text, 1);
                ret.Show();
                this.Close();
            }
        }

        private void btnRegisManager_Click(object sender, EventArgs e)
        {
            bool valid = UserIsValid();

            if (txtBoxName.Text == "" || !valid)
                MessageBox.Show("Error!", "Please enter a valid username!");
            else if (txtBoxPass.Text == "")
                MessageBox.Show("Error!", "Please enter a valid password!");
            else
            {
                log.users[log.accountCount++] = new Manager(txtBoxName.Text, txtBoxPass.Text, 2);
                ret.Show();
                this.Close();
            }
        }

        private bool UserIsValid()
        {
            bool valid = true;

            for (int i = 0; i < log.accountCount; i++)
            {
                if (log.users[i].getName() == txtBoxName.Text)
                    valid = false;
            }
            return valid;
        }
    }
}
