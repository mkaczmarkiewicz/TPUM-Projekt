using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using GitBay2.Data;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace GitBay2.Logic
{
    internal class MarketManager : AMarketManager
    {
        List<ACurrency> currencies;       

        public MarketManager()
        {
            currencies = new List<ACurrency>();
            StartServer();
        }

        public class Echo : WebSocketBehavior
        {
            protected override void OnMessage(MessageEventArgs e)
            {
                Console.WriteLine("Server: I received message: " + e.Data);
                Send(e.Data);
            }
        }

        private void StartServer()
        {
            WebSocketServer wsserv = new WebSocketServer("ws://127.0.0.1:7890");

            wsserv.AddWebSocketService<Echo>("/Echo");

            wsserv.Start();
            Console.WriteLine("Server started at " + wsserv.Port);
            Console.ReadLine();
            wsserv.Stop();
        }

        override public float GetPrice(string name)
        {
            foreach (ACurrency c in currencies)
            {
                if (c.GetName() == name)
                    return c.GetPrice();
            }
            return 0;
        }

        public void SetPrice(string name, float p)
        {
            foreach (ACurrency c in currencies)
            {
                if (c.GetName() == name)
                    c.SetPrice(p);
            }
        }

        public float GetAccountBalance(AAccount a)
        {
            return a.GetBalance();
        }

        public void ChangeAccountBalance(AAccount a, float p)
        {
            a.ChangeBalance(p);
        }

        override public void ChangeCurrenciesValues()
        {
            Random rand = new Random();
            float tmp = 0;
            if (currencies.Count > 0)
            {
                foreach (ACurrency c in currencies)
                {
                    tmp = (((float)rand.NextDouble() * 10) - 5) * 0.01f;
                    c.SetPrice(c.GetPrice() * (1 + tmp));
                    //Console.WriteLine(c.GetPrice());
                }
            }
        }

        public void AddCurrency(ACurrency c)
        {
            currencies.Add(c);
        }

        override public void AddCurrency(string name, float price)
        {
            currencies.Add(ACurrency.CreateCurrency(name, price));
        }       

        public void ShowOnScreen()
        {
            MessageBox.Show("Button is clicked!");
        }

        override public string GetCurrencyName(int i)
        {
            return currencies[i].GetName();
        }      

        override public float GetCurrencyPrice(int i)
        {
            return currencies[i].GetPrice();
        }


        /*
        override public void PLNExchange(float f)
        {
            user.GetAccount("PLN").ChangeBalance(f);
        }

        override public void CurrencyExchange(float f, string cryptoName)
        {
            user.GetAccount(cryptoName).ChangeBalance(f);
        } */



        /*public void KeepUpdating()
        {
            DateTime startingTime = DateTime.Now;
            DateTime compareTime = DateTime.Now;
            while (true)
            {                
                compareTime = DateTime.Now;
                if (startingTime.AddTicks(200000) < compareTime)
                {
                    ChangeCurrenciesValues();
                    startingTime = DateTime.Now;
                }
            }
        }*/

        
    }
}


