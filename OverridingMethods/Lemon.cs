using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingMethods
{
    class Lemon
    {
        double price;

        public Lemon(double price)
        {
            this.price = price;
        }

        public static Lemon operator +(Lemon one, Lemon two)
        {
            return new Lemon(one.price + two.price);
        }

        public static Lemon operator++(Lemon lemon)
        {
            return new Lemon(lemon.price += lemon.price);
        }

        public override string ToString()
        {
            return $"Цена лемона - {price}";
        }
    }
}
