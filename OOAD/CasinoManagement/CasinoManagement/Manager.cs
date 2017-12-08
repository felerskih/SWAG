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
        private List<Message> messages;

        public Manager(string u, string p) : base(u, p)
        {

        }
        public bool LoadMessages(Message[] m)
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader("filename"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == username)
                        {
                            while ((line = sr.ReadLine()) != "")
                                //need to create message file format
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
    }
}
