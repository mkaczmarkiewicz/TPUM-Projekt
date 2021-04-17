using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitBay2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void ChangeBalanceTest()
        {
            Account a = new Account("PLN", 0);
            float change = 1;

            a.ChangeBalance(change);

            float expectedValue = 1;
            Assert.AreEqual(expectedValue, a.GetBalance());
        }
    }
}