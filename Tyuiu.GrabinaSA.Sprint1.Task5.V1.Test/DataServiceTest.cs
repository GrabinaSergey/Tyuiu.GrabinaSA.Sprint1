using Tyuiu.GrabinaSA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.GrabinaSA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.DistanceBetweenDots(0, 0, 3, 0);
            Assert.AreEqual(res, 3);
        }
    }
}