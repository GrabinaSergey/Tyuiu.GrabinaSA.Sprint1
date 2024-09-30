using Tyuiu.GrabinaSA.Sprint1.Task6.V17.Lib;
namespace Tyuiu.GrabinaSA.Sprint1.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, new DataService().CheckPalindrome("шалаш"));
        }
    }
}