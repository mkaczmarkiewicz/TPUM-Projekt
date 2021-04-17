using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
{
    public class Account : IAccount
    {
        string currencyName;
        float balance;

        public Account(string name, float startingBalance)
        {
            currencyName = name;
            balance = startingBalance;
        }

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
