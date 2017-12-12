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
    public partial class SchedulePage : Form
    {
        Form ret;
        List<string> dealers = new List<string>();
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
                    dealers.Add(iter.Current.Key);
                    cboDealerSelect.Items.Add(iter.Current.Key);
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
            }
            else
                MessageBox.Show("Error in Loading Schedules!");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            writeToFile();
            this.Hide();
            ret.Show();
        }

        private void btnAddDealer_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    listBoxU1.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 1:
                    listBoxU2.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 2:
                    listBoxU3.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 3:
                    listBoxM1.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 4:
                    listBoxM2.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 5:
                    listBoxM3.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 6:
                    listBoxT1.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 7:
                    listBoxT2.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 8:
                    listBoxT3.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 9:
                    listBoxW1.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 10:
                    listBoxW2.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 11:
                    listBoxW3.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 12:
                    listBoxR1.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 13:
                    listBoxR2.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 14:
                    listBoxR3.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 15:
                    listBoxF1.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 16:
                    listBoxF2.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 17:
                    listBoxF3.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 18:
                    listBoxS1.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 19:
                    listBoxS2.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                case 20:
                    listBoxS3.Items.Add(cboDealerSelect.SelectedItem);
                    break;
                
            }
        }

        private void btnRemoveDealer_Click(object sender, EventArgs e)
        {
            try
            {
                switch(comboBox1.SelectedIndex)
                {
                    case 0:
                        listBoxS1.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 1:
                        listBoxS2.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 2:
                        listBoxS3.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 3:
                        listBoxM1.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 4:
                        listBoxM2.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 5:
                        listBoxM3.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 6:
                        listBoxT1.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 7:
                        listBoxT2.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 8:
                        listBoxT3.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 9:
                        listBoxW1.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 10:
                        listBoxW2.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 11:
                        listBoxW3.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 12:
                        listBoxR1.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 13:
                        listBoxR2.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 14:
                        listBoxR3.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 15:
                        listBoxF1.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 16:
                        listBoxF2.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 17:
                        listBoxF3.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 18:
                        listBoxU1.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 19:
                        listBoxU2.Items.Remove(cboDealerSelect.SelectedItem);
                        break;
                    case 20:
                        listBoxU3.Items.Remove(cboDealerSelect.SelectedItem);
                        break;

                }
            }
            catch
            {
                MessageBox.Show("Dealer does not work for that shift!");
            }
        }

        public void writeToFile()
        {
            using (StreamWriter st = new StreamWriter("dummySchedule.txt"))
            {
                Dictionary<string, List<string>> schedule = new Dictionary<string, List<string>>();
                foreach (string d in dealers)
                {
                    List<string> work = new List<string>();
                    if (listBoxU1.Items.Contains(d))
                        work.Add("U 1");
                    if (listBoxU2.Items.Contains(d))
                        work.Add("U 2");
                    if (listBoxU3.Items.Contains(d))
                        work.Add("U 3");
                    if (listBoxM1.Items.Contains(d))
                        work.Add("M 1");
                    if (listBoxM2.Items.Contains(d))
                        work.Add("M 2");
                    if (listBoxM3.Items.Contains(d))
                        work.Add("M 3");
                    if (listBoxT1.Items.Contains(d))
                        work.Add("T 1");
                    if (listBoxT2.Items.Contains(d))
                        work.Add("T 2");
                    if (listBoxT3.Items.Contains(d))
                        work.Add("T 3");
                    if (listBoxW1.Items.Contains(d))
                        work.Add("W 1");
                    if (listBoxW2.Items.Contains(d))
                        work.Add("W 2");
                    if (listBoxW3.Items.Contains(d))
                        work.Add("W 3");
                    if (listBoxR1.Items.Contains(d))
                        work.Add("R 1");
                    if (listBoxR2.Items.Contains(d))
                        work.Add("R 2");
                    if (listBoxR3.Items.Contains(d))
                        work.Add("R 3");
                    if (listBoxF1.Items.Contains(d))
                        work.Add("F 1");
                    if (listBoxF2.Items.Contains(d))
                        work.Add("F 2");
                    if (listBoxF3.Items.Contains(d))
                        work.Add("F 3");
                    if (listBoxS1.Items.Contains(d))
                        work.Add("S 1");
                    if (listBoxS2.Items.Contains(d))
                        work.Add("S 2");
                    if (listBoxS3.Items.Contains(d))
                        work.Add("S 3");
                    string finalS = d;
                    foreach (string str in work)
                        finalS += " " + str;
                    st.WriteLine(finalS);

                }
            }
        }
    }
}
