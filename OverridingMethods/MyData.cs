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

        public MyData(char symb)
        {
            this.symb = symb;
        }


        public char Symb
        {
            get
            {
                return symb;
            }
            set
            {
                symb = value;
            }
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

        public static MyData operator +(MyData data, string text)
        {
            return new MyData(+data, -data, text);
        }

        public static string operator ~(MyData data)
        {
            return data.text;
        }
        
        public static int operator +(MyData data)
        {
            return data.code;
        }

        public static char operator -(MyData data)
        {
            return data.symb;
        }

        public static char operator >>(MyData data, int k)
        {
            return (~data)[k];
        }

        public static char operator <<(MyData data, int k)
        {
            return (~data)[(~data).Length - k - 1];
        }

        public static MyData operator ^(MyData one, MyData two)
        {
            string text = ~one + " & " + ~two;
            return new MyData(+one, -two, text);
        }

        public static MyData operator ++(MyData data)
        {
            data.code += 10;
            return data;
        }

        public static MyData operator --(MyData data)
        {
            data.code -= 10;
            return data;
        }


        // Перегрузка операторов true, false, &, |

        public static bool operator true(MyData data)
        {
            switch (data.symb)
            {
                case 'A':
                case 'E':
                case 'T':
                case 'O':
                case 'U':
                case 'Y':
                    return true;
                default:
                    return false;
            }
        }

        public static bool operator false(MyData data)
        {
            if (data) return data.symb == 'Y';
            else return true;
        }


        public static MyData operator &(MyData one, MyData two)
        {
            if (one) return two;
            else return one;
        }

        public static MyData operator |(MyData one, MyData two)
        {
            if (one) return one;
            else return two;
        }
    }
}
