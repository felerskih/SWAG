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
        

        public Manager(string u, string p) : base(u, p)
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

        //So I didn't do delete because you basically have to read the whole file 
        //in and remove the line that is message and then re write to the file and I wanted to go home instead. 
        //hope this helps!
        public bool DeleteMessage(string text, string sender)
        {
            string line;
            try
            {
                using (StringReader sr = new StringReader("filename"))
                {
                    line = sr.ReadLine();
                    while (line != null && line != username)
                        sr.ReadLine();
                    if(line == username)
                    {

                    }

                }
            }
        }
        public bool LoadMessages()
        {
            string line;
            char[] splitter = new char[] { '/' };
            try
            {
                using (StreamReader sr = new StreamReader("filename"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == username)
                        {
                            while ((line = sr.ReadLine()) != "")
                                //fuck it i gave up. Literally the same line from WorkShcedule.cs but it doesn't work.
                                string[] values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                            //messages.Insert()

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.Write("Could not open file.");
                return false;
            }
            return true;
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
