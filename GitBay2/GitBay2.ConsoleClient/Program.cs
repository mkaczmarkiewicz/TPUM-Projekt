using System;

namespace GitBay2.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i =0; i < 10000; i++)
            GitBayAsyncClient.StartClient();
            Console.ReadLine();
        }
    }
}
