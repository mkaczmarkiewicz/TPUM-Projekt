using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay.Data
{
    interface IAccount
    {
        float GetBalance();
        float ChangeBalance(float c);
    }
}
