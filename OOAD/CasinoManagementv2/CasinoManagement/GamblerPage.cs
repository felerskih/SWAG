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
        public GamblerPage(Form frm, string u, string p, string f)
        {
            float amt = float.Parse(f);
            g = new CasinoManagement.Gambler(u, p, amt);
            InitializeComponent();
            lblFunds.Text = f;
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
                float a = float.Parse(txtAddFunds.Text);
                g.AddFunds(a);
                lblFunds.Text = g.GetFunds().ToString();
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
                float a = float.Parse(txtRemoveFunds.Text);
                if (a <= g.GetFunds())
                {
                    g.RemoveFunds(a);
                    lblFunds.Text = g.GetFunds().ToString();
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

        private void GamblerPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            string line;
            string[] values;
            string[] fileText = new string[100];
            int lineNum = 0;
            string file = "users.txt";
            using (StreamReader str = new StreamReader(file))
            {
                line = str.ReadLine();
                fileText[lineNum++] = line;
                values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                while (line != null && values[0] != g.getName())
                {
                    fileText[lineNum++] += line;
                    line = str.ReadLine();
                    if (line != null)
                        values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                }
                System.Windows.Forms.Application.Exit();
            }
            if (values[0] == g.getName())
            {
                using (StreamWriter strW = new StreamWriter(file))
                {
                    for (int i = 0; i < lineNum; i++)
                        strW.WriteLine(fileText[i]);
                    strW.WriteLine(values[0] + " " + values[1] + " " + values[2] + " " + g.GetFunds());
                }
            }
        }
    }
}
