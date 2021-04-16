using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBay2.Data
{
    public class Currency : ICurrency
    {
        string name;
        float price;

        public Currency(string name, float price)
        {
            this.name = name;
            this.price = price;
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float p)
        {
            price = p;
        }

        public string GetName()
        {
            return name;
        }
    }
}
