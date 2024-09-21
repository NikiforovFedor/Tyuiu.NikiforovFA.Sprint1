﻿using Tyuiu.NikiforovFA.Sprint1.Task1.V14.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task1.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Никифоров Ф. А | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает данные у пользователя и         *");
            Console.WriteLine("* вычисляет по формуле (x*y)/(1+x), а после печатает результат на экране  *");
            Console.WriteLine("***************************************************************************");

            double x, y;
            Console.WriteLine("* Введите Х: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(ds.Calculate(x,y));
            
        }
    }
}
