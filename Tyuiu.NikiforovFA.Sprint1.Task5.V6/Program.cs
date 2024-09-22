using Tyuiu.NikiforovFA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task5.V6
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
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Никифоров Федор Александрович | ПКТб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая, запросив данные у пользователя,            *");
            Console.WriteLine("* вычисляет день недели                                                   *");
            Console.WriteLine("***************************************************************************");
            int k;
            Console.Write("* Введите k: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("* " + ds.Calculate(k));
        }
    }
}
