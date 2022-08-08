using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Task5
    {
        //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //б) Сделать задание, только вывод организовать в центре экрана.
        //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
        
        // решение предоставил Юрченко Н.А.

        static void PrintCenter (string ms)
        {            
            Console.SetCursorPosition((Console.WindowWidth - ms.Length) / 2, (Console.WindowHeight-2)/2);
            Console.WriteLine(ms);
        }

        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine(ms);
        }
        static void Main(string[] args)
        {
            string firstName, lastName, city; 
            Console.WriteLine("Давайте познакомимся!");
            Console.WriteLine();
            Console.Write("Ваша фамилия:  ");
            lastName = Console.ReadLine();
            Console.Write("Ваше имя:  ");
            firstName = Console.ReadLine();
            Console.Write("Ваш город проживания:  ");
            city = Console.ReadLine();

            string ms = firstName + " " + lastName + ", " + city;
            Console.WriteLine();
            Console.WriteLine("Приятно познакомится,  "+ms);
            Console.WriteLine();
            Console.WriteLine("Нажми любую клавишу для вывода твоих данных по центру экрана");
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Метод вывода по центру экрана");
            Console.WriteLine("Нажми любую клавишу для ввода координат курсора и последующего вывода на консоль");
            PrintCenter(ms);

            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Метод вывода по центру экрана");
            Console.Write ("Введите координату Х для курсора:  ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите координату Y для курсора:  ");
            int y = int.Parse(Console.ReadLine());

            Console.Clear();
            Print(ms,x,y);


            Console.ReadLine();

        }
    }
}
