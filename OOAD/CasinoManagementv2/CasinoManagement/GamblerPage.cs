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
            lblFunds.Text = g.GetFunds().ToString();
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
            string line;
            List<string> lines = new List<string>();
            string file = "users.txt";
            using (StreamReader str = new StreamReader(file))
            {
                line = str.ReadLine();
                while(line != null)
                {
                    lines.Add(line);
                    line = str.ReadLine();
                }
                    
            }
            using (StreamWriter strW = new StreamWriter(file))
            {

                for (List<string>.Enumerator iter = lines.GetEnumerator(); iter.Current != lines.Last(); iter.MoveNext())
                {
                    if (iter.Current.Contains(g.getName()))
                    {
                        lines.Remove(iter.Current);
                        lines.Add(g.print() + 0 + g.GetFunds());
                    }
                }
                for (List<string>.Enumerator iter = lines.GetEnumerator(); iter.Current != lines.Last(); iter.MoveNext())
                {
                    strW.WriteLine(iter.Current);
                }
                File.Replace("editUsers.txt", file, "backup.txt");
            }
                
            CasinoManagement.LoginPage log = new LoginPage();
            this.Close();
            log.Show();
        }
    }
}
