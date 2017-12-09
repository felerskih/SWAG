using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoManagement
{
    class ManageFunds
    {
        public void AddFunds (float amt, Gambler g)
        {
            g.AddFunds(amt);
        }

        public void RemoveFunds(float amt, Gambler g)
        {
            g.RemoveFunds(amt);
        }
    }
}
