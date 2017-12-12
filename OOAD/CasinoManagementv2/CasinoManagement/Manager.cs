using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CasinoManagement
{
    class Manager : User
    {
        private List<Gambler> flagged;
        //private List<Message> messages;
        

        public Manager(string u, string p, int t) : base(u, p, t)
        {

        }

        //Make sure receiver is dealer
        public bool CreateMessage(string text, string receiver)
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader("filename"))
                {
                    line = sr.ReadLine();
                    while (line != null && line != receiver)
                        line = sr.ReadLine();
                    if (line == receiver)
                    {
                        while ((line != ""))
                            line = sr.ReadLine();
                        using (StreamWriter sw = new StreamWriter("filename"))
                        {
                            sw.WriteLine(text + " /" + username);
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //assumes message is in file
        public bool DeleteMessage(string text, string sender)
        {
            string nullstring = null;
            string line;
            try
            {
                using (StringReader sr = new StringReader("filename"))
                {
                    line = sr.ReadLine();
                    while (line != null && line != username)
                    {
                        line = sr.ReadLine();
                    }
                    if(line == username)
                    {
                        line = sr.ReadLine();
                        while (line != "")
                        {
                            string [] values = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                            if (values[1] == text)
                            {
                                using (StreamWriter sw = new StreamWriter("filename"))
                                {
                                    sw.WriteLine(nullstring);
                                }
                                return true;
                            }
                            sr.ReadLine();
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                //placeholder until i figure out what i want to do
            }
            return false;
        }

        //returns error message in values[0]
        public string[] LoadMessages()
        {
            string line;
            string[] values = new string[100];           
            int i = 0;
            values[i] = "";
            try
            {
                using (StreamReader sr = new StreamReader("filename"))
                {
                    line = sr.ReadLine();
                    while (line != null && line != username)
                        line = sr.ReadLine();
                    if (line == username)
                    {
                        while (line != "")
                        {
                            values[i] = line;
                            i++;
                            line = sr.ReadLine();

                        }
                        return values;
                    }
                    else
                        values[0] = "Could not find username";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write("Could not open file.");
            }
            return null;
        }

        public WorkSchedule CreateSchedule(Dictionary<string, List<string>> s)
        {
            System.IO.File.WriteAllText("path", string.Empty);
            using (StreamWriter sr = new StreamWriter("filename"))
            {
                foreach (KeyValuePair<string, List<string>> Entry in s)
                    sr.WriteLine(Entry.Key + " " + Entry.Value);
            }
            WorkSchedule sched = new WorkSchedule();
            sched.ReadSchedule();
            return sched;
        }

        public WorkSchedule CheckSchedule()
        {
            WorkSchedule s = new WorkSchedule();
            s.ReadSchedule();
            return s;
        }
    }
}
