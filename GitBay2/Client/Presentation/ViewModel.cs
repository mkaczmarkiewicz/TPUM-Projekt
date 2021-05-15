using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Presentation
{
    class ViewModel
    {
        Model model = new Model();

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
