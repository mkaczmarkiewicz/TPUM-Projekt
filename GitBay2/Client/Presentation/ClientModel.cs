using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Logic;
using WebSocketSharp;

namespace Client.Presentation
{
    class ClientModel
    {
        AUser myUser;

        public ClientModel()
        {
            ///myMarketManager = AMarketManager.CreateMarketManager(AUser.CreateUser());
            myUser = AUser.CreateUser();
        }

        public void Buy(int amount, string cryptoName)
        {
            //get price

           // using (WebSocket ws = new WebSocket("ws://127.0.0.1:8080/Echo"))
            //{
            //    ws.Send((-Convert.ToInt32(amount) * price ).ToString());
           // }

            //pass this data to server and start function

            //myMarketManager.PLNExchange(-Convert.ToInt32(amount) * myMarketManager.GetPrice(cryptoName));

            //myMarketManager.CurrencyExchange(Convert.ToInt32(amount), cryptoName);

        }

        public void Sell(int amount, string cryptoName)
        {
            //myMarketManager.PLNExchange(Convert.ToInt32(amount) * myMarketManager.GetPrice(cryptoName));

            //myMarketManager.CurrencyExchange(-Convert.ToInt32(amount), cryptoName);
        }

        /*public void IniCourses(int btcCourse, int ltcCourse, int ethCourse)
        {
            myMarketManager.AddCurrency("BTC", btcCourse);
            myMarketManager.AddCurrency("LTC", ltcCourse);
            myMarketManager.AddCurrency("ETH", ethCourse);
        }*/

        public void InitCustomer(int startingPLN, int startingBTC, int startingLTC, int startingETH)
        {
            myUser.AddAccount("PLN", startingPLN);
            myUser.AddAccount("BTC", startingBTC);
            myUser.AddAccount("LTC", startingLTC);
            myUser.AddAccount("ETH", startingETH);
        }
        /*
        public string CurrencyName(int i)
        {
            return myMarketManager.GetCurrencyName(i);
        }*/

        public string AccountName(int i)
        {
            return myUser.GetAccountName(i);
        }
        /*
        public float PriceOfCurrency(int i)
        {
            return myMarketManager.GetCurrencyPrice(i);
        }*/

        public float AccountBalance(int i)
        {
            return myUser.GetAccountBalance(i);
        }

        /*public void ChangeCurrencyValues()
        {
            myUser.ChangeCurrenciesValues();
        }*/
    }
}
