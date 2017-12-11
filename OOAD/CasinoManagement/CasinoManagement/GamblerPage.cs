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
            string line;
            string fileText ="";
            string[] values = new string[4];
            //List<string> lines = new List<string>();
            string file = "users.txt";
            try
            {
                using (StreamReader str = new StreamReader(file))
                {
                    line = str.ReadLine();
                    fileText += line;
                    values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                    while (line != null && values[0] != g.getName())
                    {
                        fileText += "\n" + line;
                        line = str.ReadLine();
                        if (line != null)
                            values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                    }
                    /*while(line != null)
                    {
                        fileText += "\n" + line;
                        line = str.ReadLine();
                    }
                    if (line == null)
                        fileText += "\n" + line;*/
                }
                    if (values[0] == g.getName())
                    {
                        using (StreamWriter strW = new StreamWriter(file))
                        {
                            strW.Write(fileText);
                            strW.WriteLine(values[0] + " " + values[1] + " " + values[2] + " " + g.GetFunds());
                        }
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception is " + ex);
            }
                
            CasinoManagement.LoginPage log = new LoginPage();
            this.Close();
            log.Show();
        }
    }
}
