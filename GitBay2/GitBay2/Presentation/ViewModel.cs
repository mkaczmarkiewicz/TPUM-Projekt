using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Presentation
{
    

    class ViewModel
    {
        Model model = new Model();

        public void InitMarket()
        {
            model.IniCourses(250, 10, 99);
           // model.InitCustomer(model.startingPLN, model.startingBTC, model.startingLTC, model.startingETH);            
        }

        public string FetchCurrencyName(int i)
        {
            return model.CurrencyName(i);
        }

       /* public string FetchAccountName(int i)
        {
            return model.AccountName(i);
        }*/

        public float FetchPriceOfCurrency(int i)
        {
            return model.PriceOfCurrency(i);
        }

        /*public float FetchAccountBalance(int i)
        {
            return model.AccountBalance(i);
        }*/

        public void ChangeCurrencyValues()
        {
            model.ChangeCurrencyValues();
        }

        public void BuyCrypto(string price, string currencyName)
        {
            model.Buy(Convert.ToInt32(price), currencyName);
        }

        public void SellCrypto(string price, string currencyName)
        {
            model.Sell(Convert.ToInt32(price), currencyName);
        }
    }
}
