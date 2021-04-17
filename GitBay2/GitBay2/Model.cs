using GitBay2.Data;
using GitBay2.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2
{
    public class Model
    {
        public User myUser = new User();
        public Account plnAccount = new Account("PLN", 10000);
        public Account btcAccount = new Account("BTC", 0);
        public Account ltcAccount = new Account("LTC", 0);
        public Account ethAccount = new Account("ETH", 0);

        public MarketManager myMarketManager = new MarketManager();
        public Currency bitcoin = new Currency("BTC", 250);
        public Currency litecoin = new Currency("LTC", 10);
        public Currency etherium = new Currency("ETH", 99);

        public Model(){ }
    }
}
