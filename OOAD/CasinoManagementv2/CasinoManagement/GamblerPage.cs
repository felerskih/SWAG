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
    public partial class GamblerPage : Form
    {
        Gambler g;
        Form ret;
        public GamblerPage(Form frm, User usr)
        {
            g = (Gambler)usr;
            InitializeComponent();
            lblFunds.Text = string.Format("{0:C2}", g.GetFunds());
            ret = frm;
        }

        public GamblerPage()
        {
            InitializeComponent();
        }

        private void GamblerPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFunds_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtAddFunds.Text);
                a = Math.Round(a, 2);
                g.AddFunds(a);
                lblFunds.Text = string.Format("{0:C2}", g.GetFunds());
            }
            catch
            {
                MessageBox.Show("Error!", "Please enter a float!");
            }
            
        }

        private void btnRemoveFunds_Click(object sender, EventArgs e)
        {
            try
            {
                double a = float.Parse(txtRemoveFunds.Text);
                a = Math.Round(a, 2);
                if (a <= g.GetFunds())
                {
                    g.RemoveFunds(a);
                    lblFunds.Text = string.Format("{0:C2}", g.GetFunds());
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Please enter a float!");
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            ret.Show();
        }

        private void GamblerPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            ret.Show();
            this.Hide();
        }
    }
}
