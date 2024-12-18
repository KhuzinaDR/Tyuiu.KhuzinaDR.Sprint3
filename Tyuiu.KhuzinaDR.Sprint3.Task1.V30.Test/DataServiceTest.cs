using Tyuiu.KhuzinaDR.Sprint3.Task1.V30.Lib;
namespace Tyuiu.KhuzinaDR.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidSum()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 12;
            double value = 0.5;
            double wait = 3.589;
            var res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}