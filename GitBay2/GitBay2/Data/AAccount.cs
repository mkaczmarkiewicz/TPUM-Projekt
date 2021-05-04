using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
{
    public abstract class AAccount
    {
        public abstract string GetName();
        public abstract float GetBalance();
        public abstract void ChangeBalance(float c);

        public static AAccount CreateAccount(string name, float startingBalance)
        {
            return new Account(name, startingBalance);
        }
    }
}
