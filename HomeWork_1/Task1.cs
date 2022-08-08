using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Task1
    {
        
        //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
        //В результате вся информация выводится в одну строчку:
        // а) используя склеивание;
        // б) используя форматированный вывод;
        // в) используя вывод со знаком $.

        // решение предоставил Юрченко Н.А.


        static void PrintGluing (string name, string lastname, string age, string height, string weight)
        {
            Console.WriteLine("Вывод строки использую метод склеивания");
            Console.WriteLine("Имя: "+ name+" Фамилия: "+ lastname+ " Возраст: "+ age+" Рост: "+height+" Вес: "+ weight);
        }

        static void PrintForm (string name, string lastname, string age, string height, string weight)
        {
            Console.WriteLine("Вывод строки использую метод форматированого вывода");
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", name, lastname, age, height, weight);
        }
        static void PrintInterpolation(string name, string lastname, string age, string height, string weight)
        {
            Console.WriteLine("Вывод строки использую метод интерполяции");
            Console.WriteLine($"Имя: {name} Фамилия: {lastname} Возраст: {age} Рост: {height} Вес: {weight}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Заполните анкету в соответствии с запрошенными парамаетрами");
            
            Console.Write("Введите имя:  ");
            string Name = Console.ReadLine();
            
            Console.Write("Введите фамилия:  ");
            string Lastname = Console.ReadLine();
            
            Console.Write("Введите возраст:  ");
            string Age = Console.ReadLine();
            
            Console.Write("Введите рост:  ");
            string Height = Console.ReadLine();

            Console.Write("Введите вес:  ");
            string Weight = Console.ReadLine();

            PrintGluing(Name, Lastname, Age, Height, Weight);
            PrintForm(Name, Lastname, Age, Height, Weight);
            PrintInterpolation(Name, Lastname, Age, Height, Weight);

            Console.ReadLine();

        }
    }
}
