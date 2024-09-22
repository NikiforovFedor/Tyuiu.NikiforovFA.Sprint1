using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NikiforovFA.Sprint1.Task3.V19.Lib
{
    public class DataService : ISprint1Task3V19
    {
        public bool ElephCanMove(double x1, double x2, double y1, double y2)
        {
            if ((Math.Abs(x1 - y1)) == (Math.Abs(x2 - y2)))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
