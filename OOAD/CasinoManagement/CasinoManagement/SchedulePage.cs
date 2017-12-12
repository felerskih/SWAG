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
            
            WorkSchedule ws = new WorkSchedule();
            if (ws.ReadSchedule())
            {
                Dictionary<string, List<string>> schedule = ws.getSchedule();
                Dictionary<string, List<string>>.Enumerator iter = schedule.GetEnumerator();
                while(iter.MoveNext())
                {
                    List<string>.Enumerator it = iter.Current.Value.GetEnumerator();
                    while(it.MoveNext())
                    { 
                        string s = it.Current;
                        string[] values = s.Split(' ');
                        switch (values[0])
                        {
                            case "M":
                                if (values[1] == "1")
                                    listBoxM1.Items.Add(iter.Current.Key);
                                else if (values[1] == "2")
                                    listBoxM2.Items.Add(iter.Current.Key);
                                else if (values[1] == "3")
                                    listBoxM3.Items.Add(iter.Current.Key);
                                break;
                            case "T":
                                if (values[1] == "1")
                                    listBoxT1.Items.Add(iter.Current.Key);
                                else if (values[1] == "2")
                                    listBoxT2.Items.Add(iter.Current.Key);
                                else if (values[1] == "3")
                                    listBoxT3.Items.Add(iter.Current.Key);
                                break;
                            case "W":
                                if (values[1] == "1")
                                    listBoxW1.Items.Add(iter.Current.Key);
                                else if (values[1] == "2")
                                    listBoxW2.Items.Add(iter.Current.Key);
                                else if (values[1] == "3")
                                    listBoxW3.Items.Add(iter.Current.Key);
                                break;
                            case "R":
                                if (values[1] == "1")
                                    listBoxR1.Items.Add(iter.Current.Key);
                                else if (values[1] == "2")
                                    listBoxR2.Items.Add(iter.Current.Key);
                                else if (values[1] == "3")
                                    listBoxR3.Items.Add(iter.Current.Key);
                                break;
                            case "F":
                                if (values[1] == "1")
                                    listBoxF1.Items.Add(iter.Current.Key);
                                else if (values[1] == "2")
                                    listBoxF2.Items.Add(iter.Current.Key);
                                else if (values[1] == "3")
                                    listBoxF3.Items.Add(iter.Current.Key);
                                break;
                            case "S":
                                if (values[1] == "1")
                                    listBoxS1.Items.Add(iter.Current.Key);
                                else if (values[1] == "2")
                                    listBoxS2.Items.Add(iter.Current.Key);
                                else if (values[1] == "3")
                                    listBoxS3.Items.Add(iter.Current.Key);
                                break;
                            case "U":
                                if (values[1] == "1")
                                    listBoxU1.Items.Add(iter.Current.Key);
                                else if (values[1] == "2")
                                    listBoxU2.Items.Add(iter.Current.Key);
                                else if (values[1] == "3")
                                    listBoxU3.Items.Add(iter.Current.Key);
                                break;
                        }
                    }
                    
                }
                MessageBox.Show("the good fuck");
            }
            else
                MessageBox.Show("the bad fuck");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ret.Show();
        }
    }
}
