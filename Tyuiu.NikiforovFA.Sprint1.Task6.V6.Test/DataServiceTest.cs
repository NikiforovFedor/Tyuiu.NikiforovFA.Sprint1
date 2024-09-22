using Tyuiu.NikiforovFA.Sprint1.Task6.V6.Lib;
namespace Tyuiu.NikiforovFA.Sprint1.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void DeleteFirstLetterValid()
        {
            DataService ds = new DataService();
            string h = "Hello World";
            Assert.AreEqual("ello orld", ds.DeleteFirstLetter(h));
        }
    }
}