﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoManagement
{
    class Gambler : User
    {
        private float funds = 0.0f;

        public Gambler(string u, string p, float f) : base(u, p)
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
    }
}
