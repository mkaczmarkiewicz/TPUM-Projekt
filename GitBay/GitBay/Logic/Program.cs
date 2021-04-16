using GitBay.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

using GitBay.Data;

namespace GitBay.Logic
{
    partial class Program
    {       
        

        static void Main(string[] args)
        {
            MarketManager marketManager = new MarketManager();
            marketManager.AddCurrency(new Currency("bitcoin", 250000));
            

            while(true)
            {
                marketManager.ChangeCurrenciesValues();
                Thread.Sleep(2000);
            }
        }

       
    }
}
