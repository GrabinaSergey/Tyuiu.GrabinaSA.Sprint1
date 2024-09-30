using Tyuiu.GrabinaSA.Sprint1.Task1.V30.Lib;
namespace Tyuiu.GrabinaSA.Sprint1.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}