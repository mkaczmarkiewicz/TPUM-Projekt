using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data
{
    internal class ClientAccount : ClientAAccount
    {
        string currencyName;
        float balance;

        public ClientAccount(string name, float startingBalance)
        {
            currencyName = name;
            balance = startingBalance;
        }

        override public void ChangeBalance(float c)
        {
            balance += c;
        }

        override public float GetBalance()
        {
            return balance;
        }

        override public string GetName()
        {
            return currencyName;
        }
    }
}
}
