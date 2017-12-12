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
        Manager m;
        Dealer d;
        string[] messages;

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
                m = (Manager)user;
                messages = m.LoadMessages();
            }
            else
            {
                d = (Dealer)user;
                messages = d.LoadMessages();
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

        private void cboRecieveMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] values;
            for(int i = 0; i < messages.Length; i++)
            {
                values = messages[i].Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                if (values[1] == cboRecieveMessages.Text)
                    txtRecieveMessage.AppendText(values[0]);
            }
        }
    }
}
