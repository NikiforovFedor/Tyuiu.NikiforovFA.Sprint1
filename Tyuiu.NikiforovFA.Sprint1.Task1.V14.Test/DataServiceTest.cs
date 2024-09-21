using Tyuiu.NikiforovFA.Sprint1.Task1.V14.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {   
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x,y);
            Assert.AreEqual(res, 1);
        }
    }
}