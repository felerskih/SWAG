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
    public partial class ManagerPage : Form
    {
        Manager m;
        Form ret;
        Form message, schedule, regis;
        public ManagerPage(Form frm, string u, string p)
        {
            m = new Manager(u, p);
            ret = frm;
            InitializeComponent();
        }
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            schedule = new CasinoManagement.SchedulePage(this, true);
            schedule.Show();
            this.Hide();
        }

        private void btnViewMessages_Click(object sender, EventArgs e)
        {
            message = new CasinoManagement.MessagePage(this);
            message.Show();
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            regis = new CasinoManagement.RegisterUserPage(this, true);
            regis.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CasinoManagement.LoginPage log = new LoginPage();
            this.Close();
            log.Show();
        }
    }
}
