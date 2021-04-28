using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitBay2.Data;

namespace GitBay2.Logic
{
    public abstract class AUser
    {
        public abstract void AddAccount(Account a);
        public abstract Account GetAccount(string name);

        public abstract string GetAccountName(int i);

        public abstract float GetAccountBalance(int i);

        public static User CreateUser()
        {
            return new User();
        }
    }
}
