using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data
{
    public abstract class ClientAAccount
    {
        public abstract string GetName();
        public abstract float GetBalance();
        public abstract void ChangeBalance(float c);

        public static ClientAAccount CreateAccount(string name, float startingBalance)
        {
            return new ClientAccount(name, startingBalance);
        }
    }
}
