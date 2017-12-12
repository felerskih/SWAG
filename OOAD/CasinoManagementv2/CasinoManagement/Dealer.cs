using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CasinoManagement
{
    class Dealer : User
    {
        //private List<Message> messages;

        
        public Dealer(string u, string p, int t) : base(u, p, t)
        {

        }
        //Check if receiver is manager needed
        public bool CreateMessage(string text, string receiver)
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader("filename"))
                {
                    line = sr.ReadLine();
                    while (line != null && line != receiver)
                    {
                        line = sr.ReadLine();
                    }
                    if (line == receiver)
                    {
                        while ((line != ""))
                        {
                            line = sr.ReadLine();
                        }//could be wrong with ""
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

        public string[] LoadMessages()
        {
            string line;
            char[] splitter = new char[] { '/' };
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

                    }
                    else
                        values[0] = "Could not find username";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write("Could not open file.");
                values[0] = "Could not open file";
            }
            return values;
        }

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
                    if (line == username)
                    {
                        line = sr.ReadLine();
                        while (line != "")
                        {
                            string[] values = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
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
            catch (Exception ex)
            {
                //placeholder until i figure out what i want to do
            }
            return false;
        }

        //Following two methods most likely not necessary
        /*public void AddFunds(float amt, Gambler g)
        {
            g.AddFunds(amt);
        }

        public void RemoveFunds(float amt, Gambler g)
        {
            g.RemoveFunds(amt);
        }*/

        public WorkSchedule CheckSchedule()
        {
            WorkSchedule s = new WorkSchedule();
            s.ReadSchedule();
            return s;
        }
    }
}
