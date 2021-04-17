using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
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
    }
}
