using Tyuiu.NikiforovFA.Sprint1.Task4.V27.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task4.V27
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
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая, запросив данные у пользователя,            *");
            Console.WriteLine("* вычисляет результат по формуле 1+sin(Pix)/(x-sqrt(abs(y)))              *");
            Console.WriteLine("***************************************************************************");
            double x,y;
            Console.Write("* Введите x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("* Введите y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(Math.Round(ds.Calculate(x,y),3));
        }
    }
}
