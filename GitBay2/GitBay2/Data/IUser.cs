using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
{
    interface IUser
    {
        void AddAccount(Account a);
        Account GetAccount(string name);
    }
}
