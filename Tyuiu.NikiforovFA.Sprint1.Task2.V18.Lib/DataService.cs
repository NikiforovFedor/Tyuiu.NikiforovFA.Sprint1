using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NikiforovFA.Sprint1.Task2.V18.Lib
{
    public class DataService : ISprint1Task2V18
    {
        public int CalculateSideSquareParallelepiped(int value, int valueTwo, int valueThree)
        {
            return (value * 2 + valueTwo * 2) * valueThree;
        }
    }
}
