using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CasinoManagement
{
    class WorkSchedule
    {
        private Dictionary<string, List<string>> schedule = new Dictionary<string, List<string>>();
        private string filename = "dummySchedule.txt";//Whatever the filename is

        public bool ReadSchedule()
        {
            string line;
            string name;
            string shift;

            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                        name = values[0];
                        List<string> dummyList = new List<string>();
                        for (int i = 1; i < values.Length; i += 2)
                        {
                            shift = values[i] + " " + values[i + 1];
                            //dummyList.Insert(i, shift);
                            dummyList.Add(shift);
                        }
                        schedule.Add(name, dummyList);
                    }
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
            return true;
        }

        public Dictionary<string, List<string>> getSchedule()
        {
            return schedule;
        }
    }
}
