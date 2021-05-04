using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitBay2.Logic;
using GitBay2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Logic.Tests
{
    [TestClass()]
    public class MarketManagerTests
    {
        [TestMethod()]
        public void GetPriceTest()
        {
            AMarketManager m = AMarketManager.CreateMarketManager(AUser.CreateUser());
            m.AddCurrency("PLN", 0);

            float expectedValue = 0;

            Assert.AreEqual(expectedValue, m.GetPrice("PLN"));
        }
    }
}