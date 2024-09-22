using Tyuiu.NikiforovFA.Sprint1.Task4.V27.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();
            double x = 3, y = 1;
            double r = 2;
            Assert.AreEqual(1, ds.Calculate(x, y));
            
        }
    }
}