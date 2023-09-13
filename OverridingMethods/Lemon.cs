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
        double weight;
        public Lemon(double price, double weight)
        {
            this.price = price;
            this.weight = weight;
        }


        /* Тоже рабочий метод, только с одним нюансом -
         * конфликтует с аналогичным перегруженным методом с возвращаемым
         * типом double, посему заключен в комментарии */

        //public static Lemon operator +(Lemon one, Lemon two)
        //{
        //    return new Lemon(one.price + two.price);
        //}

        public static double operator +(Lemon one, Lemon two)
        {
            return one.price + two.price;
        }

        // Сложение объекта класса Lemon с вещественным числом
        public static Lemon operator +(Lemon lemon, double d)
        {
            return new Lemon(lemon.price + d, lemon.weight);  // Такой объект, созданный без присваивания ссылки на него переменной, называется АНОНИМНЫМ. 
        }

        // Сложение вещественного числа с объектом класса Lemon.
        public static Lemon operator +(double d, Lemon lemon)
        {
            return lemon + d;
        }

        // Унарный оператор

        public static double operator +(Lemon lemon)
        {
            return lemon.price;
        }

        public static Lemon operator ++(Lemon lemon)
        {
            return new Lemon(lemon.price += lemon.price, lemon.weight);
        }


        // Перегрузка операторов  == и !=


        public static bool operator ==(Lemon one, Lemon two)
        {
            return one.Equals(two);
        } 

        public static bool operator !=(Lemon one, Lemon two)
        {
            return !(one == two);
        }

        // Переопределение методов Equals() и GetHashCode()

        public override bool Equals(Object obj)
        {
            Lemon lemon = (Lemon)obj;

            if(price == lemon.price && weight == lemon.weight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = (int)(price*weight/255);
            return hashCode;
        }


        public override string ToString()
        {
            return $"Цена лемона - {price}";
        }
    }
}
