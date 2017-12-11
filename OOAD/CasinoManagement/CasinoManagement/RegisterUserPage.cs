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
        public RegisterUserPage()
        {
            InitializeComponent();
        }

        public RegisterUserPage(Form frm, bool isManager)
        {

            InitializeComponent();
            if (isManager)
                pnlManageRegis.Visible = true;
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
    }
}
