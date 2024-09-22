using Tyuiu.NikiforovFA.Sprint1.Task2.V18.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Никифоров Ф. А | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая, запросив данные у пользователя,            *");
            Console.WriteLine("* вычисляет площадь боковой поверхности пареллепипеда.                    *");
            Console.WriteLine("***************************************************************************");
            int x, y, z;
            Console.Write("* Введите днину параллелепипеда: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите ширину параллелепипеда: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите высоту параллелепипеда: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("* " + ds.CalculateSideSquareParallelepiped(x, y, z));
        }
    }
}
