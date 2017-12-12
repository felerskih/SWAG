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
    public partial class MessagePage : Form
    {
        Form ret;
        User user;

        public MessagePage(Form frm, User u)
        {
            user = u;
            ret = frm;
            InitializeComponent();
        }

        private void MessagePage_Load(object sender, EventArgs e)
        {
            int type = user.getType();
            if(type == 0)
            {
                Manager m = (Manager)user;
                m.LoadMessages();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ret.Show();
            this.Hide();
        }

        private void cboSendMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
