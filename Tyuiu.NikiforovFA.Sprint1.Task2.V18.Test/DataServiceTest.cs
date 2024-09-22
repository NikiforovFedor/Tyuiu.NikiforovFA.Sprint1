using Tyuiu.NikiforovFA.Sprint1.Task2.V18.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateSideSquareParallelepipedValid()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            int z = 3;
            int r = 18;
            Assert.AreEqual(r, ds.CalculateSideSquareParallelepiped(x, y, z));

        }
    }
}