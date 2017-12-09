using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoManagement
{
    class ManageLogin
    {
        public User LogIn(string u, string p, int t, float f = 0)
        {
            User user = new User();
            if (t == 0)
                user = new Gambler(u, p, f); 
            if (t == 1)
                user = new Dealer(u, p);
            if (t == 2)
                user = new Manager(u, p);
            return user;
        }
        
    }
}
