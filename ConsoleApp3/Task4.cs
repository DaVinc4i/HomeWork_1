using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Task4
    {
        //4. Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
        //а) с использованием третьей переменной;
        //б) *без использования третьей переменной.

        // решение предоставил Юрченко Н.А.
        static int Parsing (string value)
        {
            int a = int.Parse(value);
            
            return a;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Сейчас произойдет волшебство и мы поменяем значения местами");
            Console.WriteLine();

            Console.Write("Введите числовое значение A:  ");
            string a = Console.ReadLine();
            var a1 = Parsing(a);
            var a2 = a1;//для возврата значений в исходное состояние

            Console.Write("Введите числовое значение B:  ");
            string b = Console.ReadLine();
            var b1 = Parsing(b);
            var b2 = b1;//для возврата значений в исходное состояние

            Console.WriteLine();

            Console.WriteLine("Вжух! (используем дополнительную переменную)");
            int c = a1;
            a1 = b1;
            b1 = c;

            Console.WriteLine($"Значение А: {a1}, значение B: {b1} ");

            Console.WriteLine();

            Console.WriteLine("Вжух! Вернем значения к исходному состоянию");
            a1 = a2;
            b1 = b2;

            Console.WriteLine($"Значение А: {a}, значение B: {b} ");
            Console.WriteLine();
            Console.WriteLine("Вжух! (используем метод без использования третьей переменной)");

            a1 = a1 - b1;
            b1 = b1 + a1;
            a1 = b1 - a1;

            Console.WriteLine($"Значение А: {a1}, значение B: {b1} ");

            Console.ReadLine();
        }
    }
}
