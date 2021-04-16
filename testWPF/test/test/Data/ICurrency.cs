using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay.Data
{
    interface ICurrency
    {       
        float GetPrice();
        void SetPrice(float p);

        void GetName();
    }
}
