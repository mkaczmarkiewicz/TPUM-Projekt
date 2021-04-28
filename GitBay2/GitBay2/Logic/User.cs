using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitBay2.Data;

namespace GitBay2.Logic
{
    public class User : AUser
    {
        List<AAccount> accounts;
        public User()
        {
            accounts = new List<AAccount>();
        }

        override public void AddAccount(Account a)
        {
            accounts.Add(a);
        }

        override public Account GetAccount(string name)
        {           
            foreach(Account a in accounts)
            {
                if (a.GetName() == name)
                    return a;
            }
            return null;
        }

        override public string GetAccountName(int i)
        {
            return accounts[i].GetName();
        }

        override public float  GetAccountBalance(int i)
        {
            return accounts[i].GetBalance();
        }
    }
}
