using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Data
{
    public abstract class ClientACurrency
    {
        public abstract float GetPrice();
        public abstract void SetPrice(float p);
        public abstract string GetName();

        public static ClientACurrency CreateCurrency(string name, float price)
        {
            return new ClientCurrency(name, price);
        }
    }
}
