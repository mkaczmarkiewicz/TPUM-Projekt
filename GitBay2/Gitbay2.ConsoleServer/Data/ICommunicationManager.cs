using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.ConsoleServer.Data
{
    interface ICommunicationManager : IDisposable
    {
        void Begin();
    }
}
