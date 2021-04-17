using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
{
    public interface ICurrency
    {
        float GetPrice();
        void SetPrice(float p);
        string GetName();
    }
}
