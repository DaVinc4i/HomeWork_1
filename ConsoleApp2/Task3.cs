using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Task3
    {
        //3.Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2
        //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

        // решение предоставил Юрченко Н.А.

        static double Distance (string x1, string y1, string x2, string y2)
        {
            float a=float.Parse(x1);
            float b = float.Parse(y1);
            float c = float.Parse(x2);
            float d = float.Parse(y2);
            double result = Math.Sqrt(Math.Pow(c - a, 2) + Math.Pow(d - b, 2));
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Заполните координаты точек");
            Console.WriteLine();

            Console.Write("Введите координату Х1:  ");
            string X1 = Console.ReadLine();

            Console.Write("Введите координату Y1:  ");
            string Y1 = Console.ReadLine();

            Console.Write("Введите координату Х2:  ");
            string X2 = Console.ReadLine();

            Console.Write("Введите координату Y2:  ");
            string Y2 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Расстояние между точками (c помощью описателя 0:0.00):  {0:0.00}",Distance(X1, Y1, X2, Y2));
            Console.WriteLine();
            Console.WriteLine("Расстояние между точками (c помощью описателя 0:f2):  {0:f2}", Distance(X1, Y1, X2, Y2));
            Console.ReadLine();

        }
    }
}
