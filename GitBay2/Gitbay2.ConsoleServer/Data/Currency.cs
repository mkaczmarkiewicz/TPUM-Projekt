using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.ConsoleServer.Data
{
    internal class Currency : ACurrency
    {
        string name;
        float price;

        public Currency(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        override public float GetPrice()
        {
            return price;
        }

        override public void SetPrice(float p)
        {
            price = p;
        }

        override public string GetName()
        {
            return name;
        }
    }
}
