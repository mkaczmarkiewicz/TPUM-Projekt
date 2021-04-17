using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
{
    public interface IAccount
    {
        string GetName();
        float GetBalance();
        void ChangeBalance(float c);
    }
}
