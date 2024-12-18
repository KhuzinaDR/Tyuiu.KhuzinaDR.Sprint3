using Tyuiu.KhuzinaDR.Sprint3.Task0.V11.Lib;

namespace Tyuiu.KhuzinaDR.Sprint3.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0.042, ds.GetSumSeries(5, 1, 10));
        }
    }
}