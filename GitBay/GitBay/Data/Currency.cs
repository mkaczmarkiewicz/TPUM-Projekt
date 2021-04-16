using GitBay.Data;

namespace GitBay.Data
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
