using System;
using System.Net.WebSockets;

namespace GitBay2.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(var i =0; i < 10000; i++);
            var client = new GitBayAsyncClient();
            client.StartClient();
            Console.ReadLine();
        }
    }
}
