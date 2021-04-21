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
        private bool flag;

        public Gambler(string u, string p, int t, double f, bool fl) : base(u, p, t)
        {
            funds = f;
            funds = Math.Round(funds, 2);
            flag = fl;
        }

        public Gambler(string u, string p, int t) : base(u, p, t)
        {
            funds = 0;
            flag = false;
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

        public override string toString()
        {
            return base.toString() + " " + funds + " " + flag.ToString();
        }

        public bool GetFlag()
        {
            return flag;
        }

        public bool ToggleFlag()
        {
            flag = !flag;
            return flag;
        }
    }
}
