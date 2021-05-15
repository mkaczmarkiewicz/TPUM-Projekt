using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Presentation
{
    class ClientModel
    {
        AMarketManager myMarketManager;

        public ClientModel()
        {
            ///myMarketManager = AMarketManager.CreateMarketManager(AUser.CreateUser());
        }

        public void Buy(int amount, string cryptoName)
        {
            myMarketManager.PLNExchange(-Convert.ToInt32(amount) * myMarketManager.GetPrice(cryptoName));

            myMarketManager.CurrencyExchange(Convert.ToInt32(amount), cryptoName);

        }

        public void Sell(int amount, string cryptoName)
        {
            myMarketManager.PLNExchange(Convert.ToInt32(amount) * myMarketManager.GetPrice(cryptoName));

            myMarketManager.CurrencyExchange(-Convert.ToInt32(amount), cryptoName);
        }
    }
}
