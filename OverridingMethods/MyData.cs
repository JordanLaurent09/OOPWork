using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingMethods
{
    class MyData
    {
        string text;
        char symb;
        int code;

        public MyData(int code, char symb, string text)
        {
            this.code = code;
            this.symb = symb;
            this.text = text;
        }


        // Перегрузка метода ToString()

        public override string ToString()
        {
            return $"integer field is {code}, symbol field is {symb} and text field is {text}";
        }

        // Различные виды перегрузок операций +, -, >>, <<, ++, --, ^

        public static MyData operator +(MyData data, int number)
        {
            return new MyData(+data + number, -data, ~data);
        }

        public static MyData operator -(MyData data, int number)
        {
            return new MyData(+data - number, -data, ~data);
        }

        public static int operator +(int number, MyData data)
        {
            return number + (+data);
        }

        public static int operator -(int number, MyData data)
        {
            return number - (+data);
        }
    }
}
