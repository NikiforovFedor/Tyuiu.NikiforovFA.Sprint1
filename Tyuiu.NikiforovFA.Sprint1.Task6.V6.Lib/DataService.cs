using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.NikiforovFA.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] lis = value.Split(" ");
            string r = "";
            int k = 0;
            foreach (string s in lis)
            {
                k++;
                if (lis.Length != k)
                {
                    r += s.Remove(0, 1) + " ";
                }
                else
                {
                    r += s.Remove(0, 1);
                }
            }
            return r;




        }
    }
}
