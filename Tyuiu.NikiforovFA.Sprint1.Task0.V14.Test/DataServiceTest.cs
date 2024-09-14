using Tyuiu.NikiforovFA.Sprint1.Task0.V14.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}