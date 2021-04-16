using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GitBay2.Data;

namespace GitBay2.Logic
{
    class MarketManager
    {
        List<ICurrency> currencies;

        public MarketManager()
        {
            currencies = new List<ICurrency>();
        }

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

        public void ChangeCurrenciesValues()
        {
            Random rand = new Random();
            float tmp = 0;
            foreach (ICurrency c in currencies)
            {
                tmp = (((float)rand.NextDouble() * 10) - 5) * 0.01f;
                c.SetPrice(c.GetPrice() * (1 + tmp));
                Console.WriteLine(c.GetPrice());
            }
        }

        public void AddCurrency(ICurrency c)
        {
            currencies.Add(c);
        }
    }
}
