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
    public partial class SchedulePage : Form
    {
        Form ret;
        public SchedulePage(Form frm)
        {
            ret = frm;
            InitializeComponent();
        }

        public SchedulePage(Form frm, bool isManager)
        {
            InitializeComponent();
            if (isManager)
                pnlManageDealers.Visible = true;
            ret = frm;
            
        }
        private void SchedulePage_Load(object sender, EventArgs e)
        {
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ret.Show();
        }
    }
}
