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
        private Dictionary<string, List<string>> schedule;
        private string filename = "";//Whatever the filename is
        
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
                        for(int i = 1; i < values.Length; i += 2)
                        {
                            shift = " " + values[i] + " " + values[i + 1];
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                System.Console.Write("Could not open file.");
                return false;
            }
            return true;
        }
    }
}
