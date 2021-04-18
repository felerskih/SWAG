using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoManagement
{
    class Gambler : User
    {
        public List<string> gamblerList = new List<string>();
        private double funds = 0.0f;

        public Gambler(string u, string p, int t, double f) : base(u, p, t)
        {
            funds = f;
            funds = Math.Round(funds, 2);
        }

        public void AddFunds(double f)
        {
            funds += f;
            funds = Math.Round(funds, 2);
        }

        public void RemoveFunds(double f)
        {
            funds -= f;
            funds = Math.Round(funds, 2);
        }

        public double GetFunds()
        {
            return funds;
        }

        public string getName()
        {
            return base.username;
        }
        
        public string print()
        {
            return base.username + base.password;
        }

        public override string toString()
        {
            return base.toString() + " " + funds;
        }
    }
}
