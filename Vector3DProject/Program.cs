using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector3DProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D one = new Vector3D(0.5, 0, 1);
            Vector3D two = new Vector3D(0, 0.5, 1);

            // Сумма векторов

            Vector3D sum = one + two;
            Console.WriteLine($"Координаты новоого вектора {sum.X},{sum.Y},{sum.Z}");

            // Разность векторов

            Vector3D sub = one - two;
            Console.WriteLine($"Координаты новоого вектора {sub.X},{sub.Y},{sub.Z}");

            // Скалярное произведение

            Console.WriteLine(one * two);

            // Длина вектора

            Console.WriteLine(one.Vector3DLength());

            // Косинус угла между векторами

            Console.WriteLine(Vector3D.Cos(one, two));
            Console.WriteLine(one.Cos(two));
        }
    }
}
