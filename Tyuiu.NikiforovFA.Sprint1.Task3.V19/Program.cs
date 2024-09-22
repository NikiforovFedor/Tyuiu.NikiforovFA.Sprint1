using Tyuiu.NikiforovFA.Sprint1.Task3.V19.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task3.V19
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
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая, запросив данные у пользователя,            *");
            Console.WriteLine("* вычисляет возможность перемещения слона на шахматной доске.             *");
            Console.WriteLine("***************************************************************************");
            double x1,x2,y1,y2;
            Console.Write("* Введите x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("* " + ds.ElephCanMove(x1,x2,y1,y2));
        }
    }
}
