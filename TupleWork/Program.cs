using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleWork
{
    class Program
    {
        static void Main(string[] args)
        {
            (string, int, double[]) studentOne = ("Ivanov I.I.", 2, new double[5] { 3, 4, 5, 3, 3 });
            (string, int, double[]) studentTwo = ("Petrov P.P.", 2, new double[5] { 5, 4, 5, 5, 5 });
            (string, int, double[]) studentThree = ("Kusnetsov K.K.", 1, new double[5] { 4, 4, 4, 4, 5 });
            (string, int, double[]) studentFour = ("Aleksandrov A.A.", 3, new double[5] { 3, 4, 5, 3, 3 });
            (string, int, double[]) studentFive = ("Trofimov T.T.", 1, new double[5] { 3, 3, 3, 3, 2 });
            (string, int, double[]) studentSix = ("Sidorov S.S.", 2, new double[5] { 3, 4, 5, 2, 2 });
            (string, int, double[]) studentSeven = ("Michailov M.M.", 3, new double[5] { 3, 4, 3, 3, 3 });
            (string, int, double[]) studentEight = ("Vladimirov V.V.", 3, new double[5] { 5, 4, 5, 4, 2 });
            (string, int, double[]) studentNine = ("Romanov R.R.", 2, new double[5] { 3, 3, 3, 3, 3 });
            (string, int, double[]) studentTen = ("Bobrov B.B.", 1, new double[5] { 5, 2, 4, 3, 5 });

            (string, int, double[])[] students = new (string, int, double[])[10];
            students[0] = studentOne;
            students[1] = studentTwo;
            students[2] = studentThree;
            students[3] = studentFour;
            students[4] = studentFive;
            students[5] = studentSix;
            students[6] = studentSeven;
            students[7] = studentEight;
            students[8] = studentNine;
            students[9] = studentTen;

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Item1} {item.Item2} {item.Item3.Average()}");
            }



            for (int i = 0; i < students.Length - 1; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (students[i].Item3.Average() > students[j].Item3.Average())
                    {
                        (string, int, double[]) temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }

            Console.WriteLine();

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Item1} {item.Item2} {item.Item3.Average()}");
            }

            Console.WriteLine();

            foreach (var item in students)
            {
                if (!item.Item3.Contains(1) && !item.Item3.Contains(2) && !item.Item3.Contains(3))
                {
                    Console.WriteLine($"{item.Item1} {item.Item2}");
                }
            }
        }
    }
}
