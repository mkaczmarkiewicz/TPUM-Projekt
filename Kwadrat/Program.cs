using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwadrat
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Square
    {
        double a;

        public Square (double _a)
        {
            a = _a;
        }

        public void setSide(double _a)
        {
            a = _a;
        }

        public double getSide()
        {
            return a;
        }

        public double getArea()
        {
            return a * a;
        }
    }
}
