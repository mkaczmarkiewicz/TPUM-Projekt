using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

using GitBay.Data;

namespace GitBay.Logic
{
    class MarketManager
    {
        List<ICurrency> currencies;

        IAccount account;

        private static Timer myTimerr;

        public float GetPrice(ICurrency c)
        {
            return c.GetPrice();
        }

        public void SetPrice(ICurrency c, float p)
        {
            c.SetPrice(p);
        }       

        public float GetAccountBalance(IAccount a)
        {
            return a.GetBalance();
        }

        public void ChangeAccountBalance(IAccount a, float p)
        {
            a.ChangeBalance(p);
        }

        void ChangeCurrenciesValues() {
            Random rand = new Random();
            float tmp = 0;
            Console.WriteLine(tmp);
            foreach (ICurrency c in currencies)
            {
                tmp = ((float)rand.NextDouble() * 10) - 5; //range -5 to 5          
                c.SetPrice(c.GetPrice() + tmp);
            }
        }
    }
}
