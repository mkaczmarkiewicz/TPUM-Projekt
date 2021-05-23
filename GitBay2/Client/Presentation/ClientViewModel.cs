using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Presentation
{
    class ClientViewModel
    {
        ClientModel model = new ClientModel();

        public void InitCustomer()
        {
            model.InitCustomer(10000,0,0,0);
        }

        public void BuyCrypto(string price, string currencyName)
        {
            model.Buy(Convert.ToInt32(price), currencyName);
        }

        public void SellCrypto(string price, string currencyName)
        {
            model.Sell(Convert.ToInt32(price), currencyName);
        }

       /* public string FetchCurrencyName(int i)
        {
            return model.CurrencyName(i);
        }*/

        public string FetchAccountName(int i)
        {
            return model.AccountName(i);
        }

       /* public float FetchPriceOfCurrency(int i)
        {
            return model.PriceOfCurrency(i);
        }*/

        public float FetchAccountBalance(int i)
        {
            return model.AccountBalance(i);
        }

        /*public void ChangeCurrencyValues()
        {
            model.ChangeCurrencyValues();
        } */           
    }
}
