using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NikiforovFA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            int n = 0;
            while (k % 7 != 0)
            {
                k++;
                n++;
            }
            if (n <= 3)
            {
                return (Math.Abs(7 - n));
            }
            else
            {
                return (Math.Abs(n - 7));
            }
        }
    }
}