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
            for (int i = 0; i < ret.accountCount; i++)
            {
                if (ret.users[i].getType() == 0)
                    listBoxGamblers.Items.Add(ret.users[i].getName());
            }
        }
        
        public DealerPage()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            ret.Show();
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
                double a = double.Parse(txtGiveFunds.Text);
                bool validGambler = false;
                for (int i = 0; i < ret.accountCount; i++)
                {
                    if (ret.users[i].getName() == listBoxGamblers.SelectedItem.ToString())
                    {
                        a = Math.Round(a);
                        validGambler = true;
                        Gambler g = (Gambler)ret.users[i];
                        g.AddFunds(a);
                        lblFunds.Text = string.Format("{0:C2}", g.GetFunds());
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

        private void btnConfirmTake_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtRemoveFunds.Text);
                bool validGambler = false;
                for (int i = 0; i < ret.accountCount; i++)
                {
                    if (ret.users[i].getName() == listBoxGamblers.SelectedItem.ToString())
                    {
                        a = Math.Round(a);
                        validGambler = true;
                        Gambler g = (Gambler)ret.users[i];
                        g.RemoveFunds(a);
                        lblFunds.Text = string.Format("{0:C2}", g.GetFunds());
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

        private void DealerPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            ret.Show();
            this.Hide();
        }

        private void listBoxGamblers_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool valid = false;
            for (int i = 0; i < ret.accountCount; i++)
            {
                if (ret.users[i].getName() == listBoxGamblers.SelectedItem.ToString())
                {
                    valid = true;
                    Gambler g = (Gambler)ret.users[i];
                    lblFunds.Text = string.Format("{0:C2}", g.GetFunds());
                }
            }
            if (!valid)
                lblFunds.Text = "$0.00";
        }
    }
}
