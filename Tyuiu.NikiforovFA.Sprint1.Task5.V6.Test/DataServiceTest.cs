using Tyuiu.NikiforovFA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateValid()
        {
            DataService ds = new DataService();    
            int k = 13;
            Assert.AreEqual(6, ds.Calculate(k));
        }
    }
}