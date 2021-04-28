using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
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
