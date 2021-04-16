using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GitBay2.Data
{
    class Account : IAccount
    {
        string currencyName;
        float balance;

        public void ChangeBalance(float c)
        {
            balance = c;
        }

        public float GetBalance()
        {
            return balance;
        }

        public string GetName()
        {
            return currencyName;
        }
    }
}
