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
        Form ret;
        Form message;
        Form schedule;
        public DealerPage(Form frm, User usr)
        {
            /*
            d = new CasinoManagement.Dealer(u, p);
            */
            ret = frm;
            message = new CasinoManagement.MessagePage(this);
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

        }
    }
}
