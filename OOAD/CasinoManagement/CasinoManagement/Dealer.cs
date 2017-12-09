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

        
        public Dealer(string u, string p) : base(u, p)
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

        public bool LoadMessages()
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader("filename"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line == username)
                        {
                            while ((line = sr.ReadLine()) != "")
                                //need to create message file format
                                //messages.Insert()



                            return true;//inside if but outside of inner while

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.Write("Could not open file.");
                return false;
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
