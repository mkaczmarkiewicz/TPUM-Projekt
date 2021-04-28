using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
{
    public class User : AUser
    {
        List<Account> accounts;
        public User()
        {
            accounts = new List<Account>();
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
