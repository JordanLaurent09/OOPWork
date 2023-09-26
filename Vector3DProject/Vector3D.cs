using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector3DProject
{
    class Vector3D
    {
        // Приватные поля класса, обозначающие координаты вектора
        double _x;
        double _y;
        double _z;

        // Публичный конструктор 
        public Vector3D(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        // Публичные свойства для приватных полей
        public double X { 
            get 
            { 
                return _x;
            } 
            set 
            { 
                _x = value; 
            } 
        }

        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public double Z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }


        // Перегрузка оператора сложения

        public static Vector3D operator+(Vector3D one, Vector3D two)
        {
            return new Vector3D(one._x + two._x, one._y + two._y, one._z + two._z);
        }


        /* Перегрузка оператора вычитания. Кроме непосредственного 
         * поиска разности двух векторов, также может использоваться
         * для нахождения координат вектора по его начальным и конечным 
         * координатам */
        public static Vector3D operator -(Vector3D one, Vector3D two)
        {
            return new Vector3D(one._x - two._x, one._y - two._y, one._z - two._z);
        }

        // Скалярное произведение 2-х векторов

        public static double operator *(Vector3D one, Vector3D two)
        {
            return one._x * two._x + one._y * two._y + one._z * two._z;
        }

        // Метод для вычисления длины вектора

        public double Vector3DLength()
        {
            return Math.Sqrt(_x * _x + _y * _y + _z * _z);
        }

        // Косинус угла между векторами. Первый способ

        public static double Cos(Vector3D one, Vector3D two)
        {
            double modulusOne = one.Vector3DLength();
            double modulusTwo = two.Vector3DLength();
            return (one * two) / (modulusOne * modulusTwo);
        }


        // Косинус угла между векторами. Второй способ

        public double Cos(Vector3D anotherVector)
        {
            double modulusOne = this.Vector3DLength();
            double modulusTwo = anotherVector.Vector3DLength();
            return (this * anotherVector) / (modulusOne * modulusTwo);
        }
    }
}
