using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoManagement
{
    public class User
    {
        protected string username;
        protected string password;
        protected int accountType;

        public User()
        {

        }

        public User(string u, string p, int t)
        {
            username = u;
            password = p;
            accountType = t;
        }

        public string getName()
        {
            return username;
        }

        public string getPass()
        {
            return password;
        }

        public int getType()
        {
            return accountType;
        }
    }
}
