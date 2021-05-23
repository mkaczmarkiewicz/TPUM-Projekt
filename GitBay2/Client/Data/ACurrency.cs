using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data
{
    public abstract class ACurrency
    {
        public abstract float GetPrice();
        public abstract void SetPrice(float p);
        public abstract string GetName();

        public static ACurrency CreateCurrency(string name, float price)
        {
            return new Currency(name, price);
        }
    }
}
