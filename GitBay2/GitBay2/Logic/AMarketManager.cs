using GitBay2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Logic
{
    public abstract class AMarketManager
    {
        public static AMarketManager CreateMarketManager(AUser _user)
        {
            return new MarketManager(_user);
        }

        abstract public void AddCurrency(string name, float price);
        abstract public void AddAccount(string name, float balance);
        abstract public string GetCurrencyName(int i);
        abstract public string GetAccountName(int i);
        abstract public float GetCurrencyPrice(int i);
        abstract public float GetAccountBalance(int i);
        abstract public void ChangeCurrenciesValues();
        abstract public void PLNExchange(float f);
        abstract public void CurrencyExchange(float f, string cryptoName);
        abstract public float GetPrice(string name);
    }
}
