using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework
{
    class Task2

    {
        //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);
        //где m — масса тела в килограммах, h — рост в метрах.

        // решение предоставил Юрченко Н.А.

        static double IMT (string height, string weight)
        
        {
            double a = double.Parse(height);
            double b = double.Parse(weight);
            double result = a/(b*b);
            return result;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите рост:  ");
            string Height = Console.ReadLine();

            Console.Write("Введите вес:  ");
            string Weight = Console.ReadLine();

            Console.WriteLine("Индекс массы тела будет равен:  "+IMT(Height, Weight));
            Console.ReadLine();
        }
    }
}
