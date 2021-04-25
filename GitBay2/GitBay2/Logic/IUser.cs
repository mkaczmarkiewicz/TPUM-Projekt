using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitBay2.Data;

namespace GitBay2.Logic
{
    public interface IUser
    {
        void AddAccount(Account a);
        Account GetAccount(string name);

        string GetAccountName(int i);

        float GetAccountBalance(int i);
    }
}
