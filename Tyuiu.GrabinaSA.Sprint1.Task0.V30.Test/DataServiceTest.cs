using Tyuiu.GrabinaSA.Sprint1.Task0.V30.Lib;
namespace Tyuiu.GrabinaSA.Sprint1.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(96, res);
        }
    }
}