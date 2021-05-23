using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Data;
using WebSocketSharp;

namespace Client.Logic
{
    internal class User : AUser
    {
        List<AAccount> accounts;
        public User()
        {
            accounts = new List<AAccount>();
            SayHello();
        }

        public void SayHello()
        {
            using (WebSocket ws = new WebSocket("ws://127.0.0.1:7890/Echo"))
            {
               ws.OnMessage += Ws_OnMessage;

               ws.Connect();
              // ws.Send("Hello");
            }
        }

        private static void Ws_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Client: I received: " + e.Data);
        }

        override public void AddAccount(AAccount a)
        {
            accounts.Add(a);
        }

        override public void AddAccount(string name, float startingBalance)
        {
            accounts.Add(new Account(name, startingBalance));
        }

        override public AAccount GetAccount(string name)
        {           
            foreach(AAccount a in accounts)
            {
                if (a.GetName() == name)
                    return a;
            }
            return null;
        }

        override public string GetAccountName(int i)
        {
            return accounts[i].GetName();
        }

        override public float  GetAccountBalance(int i)
        {
            return accounts[i].GetBalance();
        }
    }
}
