using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoManagement
{
    class User
    {
        protected string username;
        protected string password;

        public User();

        public User(string u, string p)
        {
            username = u;
            password = p;
        }
    }
}
