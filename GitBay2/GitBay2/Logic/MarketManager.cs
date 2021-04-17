﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
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

        public void ShowOnScreen()
        {
            MessageBox.Show("Button is clicked!");
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
