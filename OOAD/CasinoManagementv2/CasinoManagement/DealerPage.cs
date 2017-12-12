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
    public partial class DealerPage : Form
    {
        Dealer d;
        LoginPage ret;
        Form message;
        Form schedule;
        public DealerPage(Form frm, User usr)
        {

            d = (Dealer)usr;
            ret = (LoginPage)frm;
            message = new CasinoManagement.MessagePage(this, d);
            schedule = new CasinoManagement.SchedulePage(this, false);
            InitializeComponent();
        }
        
        public DealerPage()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CasinoManagement.LoginPage log = new LoginPage();
            this.Close();
            log.Show();
        }

        private void btnViewMessages_Click(object sender, EventArgs e)
        {
            message.Show();
            this.Hide();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
        {
            schedule.Show();
            this.Hide();
        }

        private void DealerPage_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmGive_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtGiveFunds.Text);
                bool validGambler = false;
                for (int i = 0; i < ret.accountCount; i++)
                {
                    if (ret.users[i].getName() == txtGamblerName.Text)
                    {
                        validGambler = true;
                        Gambler g = (Gambler)ret.users[i];
                        g.AddFunds(a);
                    }
                }
                if (!validGambler)
                    MessageBox.Show("Error!", "Please enter a valid username!");
            }
            catch
            {
                MessageBox.Show("Error!", "Please enter a float!");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmTake_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(txtRemoveFunds.Text);
                bool validGambler = false;
                for (int i = 0; i < ret.accountCount; i++)
                {
                    if (ret.users[i].getName() == txtGamblerName.Text)
                    {
                        validGambler = true;
                        Gambler g = (Gambler)ret.users[i];
                        g.RemoveFunds(a);
                    }
                }
                if (!validGambler)
                    MessageBox.Show("Error!", "Please enter a valid username!");
            }
            catch
            {
                MessageBox.Show("Error!", "Please enter a float!");
            }
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            //Gambler g;
            //g.gamblerList.Add(listBoxGamblers.SelectedIndex.ToString());
        }
    }
}
