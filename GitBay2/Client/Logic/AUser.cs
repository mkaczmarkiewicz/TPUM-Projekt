using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Data;

namespace Client.Logic
{
    public abstract class AUser
    {
        public abstract void AddAccount(AAccount a);
        public abstract void AddAccount(string name, float startingBalance);
        public abstract AAccount GetAccount(string name);

        public abstract string GetAccountName(int i);

        public abstract float GetAccountBalance(int i);

        public static AUser CreateUser()
        {
            return new User();
        }
    }
}
