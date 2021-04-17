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
        private float funds = 0.0f;

        public Gambler(string u, string p, int t, float f) : base(u, p, t)
        {
            funds = f;
        }

        public void AddFunds(float f)
        {
            funds += f;
        }

        public void RemoveFunds(float f)
        {
            funds -= f;
        }

        public float GetFunds()
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
