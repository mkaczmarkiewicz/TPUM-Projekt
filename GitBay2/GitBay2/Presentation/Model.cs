using GitBay2.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Presentation
{
    public class Model
    {
        AMarketManager myMarketManager;

        public int btcCourse = 250;
        public int ltcCourse = 10;
        public int ethCourse = 99;

        public int startingPLN = 10000;
        public int startingBTC = 0;
        public int startingLTC = 0;
        public int startingETH = 0;

        public Model()
        {
            myMarketManager = AMarketManager.CreateMarketManager();
        }

        public void IniCourses(int btcCourse, int ltcCourse, int ethCourse)
        {
            myMarketManager.AddCurrency("BTC", btcCourse);
            myMarketManager.AddCurrency("LTC", ltcCourse);
            myMarketManager.AddCurrency("ETH", ethCourse);
        }
        
        /*public void InitCustomer(int startingPLN, int startingBTC, int startingLTC, int startingETH)
        {
            myMarketManager.AddAccount("PLN", startingPLN);
            myMarketManager.AddAccount("BTC", startingBTC);
            myMarketManager.AddAccount("LTC", startingLTC);
            myMarketManager.AddAccount("ETH", startingETH);
        }*/
        
        public string CurrencyName(int i)
        {
            return myMarketManager.GetCurrencyName(i);
        }

        /*public string AccountName(int i)
        {
            return myMarketManager.GetAccountName(i);
        }*/

        public float PriceOfCurrency(int i)
        {
            return myMarketManager.GetCurrencyPrice(i);
        }

        /*public float AccountBalance(int i)
        {
            return myMarketManager.GetAccountBalance(i);
        }*/

        public void ChangeCurrencyValues()
        {
            myMarketManager.ChangeCurrenciesValues();
        }

       /* public void ChangeAccountBalance(int price, string currencyName)
        {
            myMarketManager.user.GetAccount(currencyName).ChangeBalance(Convert.ToInt32(price));
        }

        public void DecreasePlnAccountBalance(string price, string currencyName)
        {
            myMarketManager.user.GetAccount(currencyName).ChangeBalance(-Convert.ToInt32(price) * myMarketManager.GetPrice(currencyName));
            

            
            
        }*/

        public void Buy(int amount, string cryptoName)
        {
            //myMarketManager.PLNExchange(-Convert.ToInt32(amount) * myMarketManager.GetPrice(cryptoName));

            //myMarketManager.CurrencyExchange(Convert.ToInt32(amount), cryptoName);
            
        }

        public void Sell(int amount, string cryptoName)
        {
            //myMarketManager.PLNExchange(Convert.ToInt32(amount) * myMarketManager.GetPrice(cryptoName));

           // myMarketManager.CurrencyExchange(-Convert.ToInt32(amount), cryptoName);
        }
    }
}
/*
 * 
 * public void Customer_Init()
        {
            myMarketManager.Customer_Account_Init(10000, 0, 0, 0);
        }

    public void Customer_Account_Init(int pln, int btc, int ltc, int eth)
        {
             = new User();
            Account plnAccount = new Account("PLN", pln);
            Account btcAccount = new Account("BTC", btc);
            Account ltcAccount = new Account("LTC", ltc);
            Account ethAccount = new Account("ETH", eth);
        }

 *  public void Market_Init()
        {
            myMarketManager.Market_Init(250, 10, 99);
        }

 * public void Market_Init(int btc, int ltc, int eth)
        {
            Currency bitcoin = new Currency("BTC", btc);
            Currency litecoin = new Currency("LTC", ltc);
            Currency etherium = new Currency("ETH", eth);

    //dodanie walut do marketu
        myMarketManager.AddCurrency(model.bitcoin);
        myMarketManager.AddCurrency(model.litecoin);
        myMarketManager.AddCurrency(model.etherium);

            //dodanie rachunków do konta użytkownika
            model.myUser.AddAccount(model.plnAccount);
            model.myUser.AddAccount(model.btcAccount);
            model.myUser.AddAccount(model.ltcAccount);
            model.myUser.AddAccount(model.ethAccount);
        }*/
