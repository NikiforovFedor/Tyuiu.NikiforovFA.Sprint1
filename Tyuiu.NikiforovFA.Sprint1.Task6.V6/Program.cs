using Tyuiu.NikiforovFA.Sprint1.Task6.V6.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task6.V6
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
            Console.WriteLine("* Написать программу, которая, запросив текст у пользователя,             *");
            Console.WriteLine("* удаляет 1 букву слова                                                   *");
            Console.WriteLine("***************************************************************************");
            string s;
            Console.Write("* Введите текст: ");
            s = Convert.ToString(Console.ReadLine());
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("* " + ds.DeleteFirstLetter(s));
        }
    }
}
