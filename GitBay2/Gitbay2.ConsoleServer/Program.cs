using System;
using GitBay2.ConsoleServer.Data;
using System.Windows;

namespace GitBay2.ConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var account = AAccount.CreateAccount("testAccount1", 15);
            var commMgr = new CommunicationManager(8080);
            commMgr.Begin();
        }
    }
}
