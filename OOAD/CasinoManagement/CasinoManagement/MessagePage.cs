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

        public MessagePage(Form frm)
        {
            ret = frm;
            InitializeComponent();
        }

        private void MessagePage_Load(object sender, EventArgs e)
        {
                
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ret.Show();
            this.Hide();
        }
    }
}
