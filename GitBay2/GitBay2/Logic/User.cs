using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitBay2.Data;

namespace GitBay2.Logic
{
    public class User : IUser
    {
        List<Account> accounts;
        public User()
        {
            accounts = new List<Account>();
        }

        public void AddAccount(Account a)
        {
            accounts.Add(a);
        }

        public Account GetAccount(string name)
        {           
            foreach(Account a in accounts)
            {
                if (a.GetName() == name)
                    return a;
            }
            return null;
        }

        public string GetAccountName(int i)
        {
            return accounts[i].GetName();
        }

        public float GetAccountBalance(int i)
        {
            return accounts[i].GetBalance();
        }
    }
}
