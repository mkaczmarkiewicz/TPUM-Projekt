using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kwadrat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwadrat.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        public void setSideTest()
        {
            Square mySquare = new Square(2);

            double input = 4;

            mySquare.setSide(input);

            Assert.AreEqual(mySquare.getSide(), input);
        }

        [TestMethod()]
        public void getSideTest()
        {
            double input = 4;

            Square mySquare = new Square(input);

            Assert.AreEqual(mySquare.getSide(), input);
        }

        [TestMethod()]
        public void getAreaTest()
        {
            double input = 4;

            Square mySquare = new Square(input);

            Assert.AreEqual(mySquare.getArea(), input * input);
        }
    }
}