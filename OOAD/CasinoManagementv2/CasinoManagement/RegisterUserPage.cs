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
                ManagerPage man = (ManagerPage)ret;
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
            bool valid = true;
            
            for (int i = 0; i < log.accountCount; i++)
            {
                if (log.users[i].getName() == txtBoxName.Text)
                    valid = false;
            }

            if (txtBoxName.Text == "" || !valid)
                MessageBox.Show("Error!", "Please enter a valid username!");
            else if (txtBoxPass.Text == "")
                MessageBox.Show("Error!", "Please enter a valid password!");
            else
            {
                log.users[log.accountCount++] = new Gambler(txtBoxName.Text, txtBoxPass.Text, 0, 0.0);
                ret.Show();
                this.Close();
            }
        }
    }
}
