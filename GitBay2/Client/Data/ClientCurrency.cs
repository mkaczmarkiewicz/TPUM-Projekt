using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data
{
    internal class ClientCurrency : ClientACurrency
    {
        string name;
        float price;

        public ClientCurrency(string name, float price)
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
