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
        MarketManager myMarketManager = new MarketManager();
        public void Customer_Init()
        {
            myMarketManager.Customer_Account_Init(10000, 0, 0, 0);
        }
        
        public void Market_Init()
        {
            myMarketManager.Market_Init(250, 10, 99);
        }

        public Model(){ }
    }
}
