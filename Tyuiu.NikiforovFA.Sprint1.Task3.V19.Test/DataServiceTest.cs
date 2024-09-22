using Tyuiu.NikiforovFA.Sprint1.Task3.V19.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ElephCanMoveValid()
        {
            DataService ds = new DataService();
            double x1 = 3, y1 = 3, x2 = 2, y2 = 4;
            
            Assert.AreEqual(true,ds.ElephCanMove(x1,y1,x2,y2));

        }
    }
}