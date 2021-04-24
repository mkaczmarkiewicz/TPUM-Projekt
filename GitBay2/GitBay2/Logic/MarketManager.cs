using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using GitBay2.Data;

namespace GitBay2.Logic
{
    public class MarketManager
    {
        List<ICurrency> currencies;

        public IUser user;

        public MarketManager()
        {
            currencies = new List<ICurrency>();

            user = new User();
        }

        public float GetPrice(string name)
        {
            foreach (ICurrency c in currencies)
            {
                if (c.GetName() == name)
                    return c.GetPrice();
            }
            return 0;
        }

        public void SetPrice(string name, float p)
        {
            foreach (ICurrency c in currencies)
            {
                if (c.GetName() == name)
                    c.SetPrice(p);
            }
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

        public void AddCurrency(string name, float price)
        {
            currencies.Add(new Currency(name, price));
        }

        public void AddAccount(string name, float balance)
        {
            user.AddAccount(new Account(name, balance));
        }

        public void ShowOnScreen()
        {
            MessageBox.Show("Button is clicked!");
        }  
        
        public string GetCurrencyName(int i)
        {
            return currencies[i].GetName();
        }

        public string GetAccountName(int i)
        {
            return user.GetAccountName(i);
        }

        public float GetCurrencyPrice(int i)
        {
            return currencies[i].GetPrice();
        }

        public float GetAccountBalance(int i)
        {
            return user.GetAccountBalance(i);
        }

        public void PLNExchange(float f)
        {
            user.GetAccount("PLN").ChangeBalance(f);
        }

        public void CurrencyExchange(float f, string cryptoName)
        {
            user.GetAccount(cryptoName).ChangeBalance(f);
        }
    }
}

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
