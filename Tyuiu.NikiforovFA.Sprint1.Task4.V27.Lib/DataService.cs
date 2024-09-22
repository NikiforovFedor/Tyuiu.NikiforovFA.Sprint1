using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NikiforovFA.Sprint1.Task4.V27.Lib
{
    public class DataService : ISprint1Task4V27
    {
        public double Calculate(double x, double y)

        {
            return Math.Round(((1 + Math.Sin(double.Pi * x)) / (x - Math.Sqrt(Math.Abs(y)))),3);
        }
    }
}
