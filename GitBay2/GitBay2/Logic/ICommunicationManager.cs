using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Logic
{
    interface ICommunicationManager : IDisposable
    {
        void Begin();
    }
}
