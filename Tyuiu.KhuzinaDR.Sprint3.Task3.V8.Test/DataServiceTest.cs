using Tyuiu.KhuzinaDR.Sprint3.Task3.V8.Lib;

namespace Tyuiu.KhuzinaDR.Sprint3.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertStringToInt()
        {
            DataService ds = new DataService();
            string str = "vc,x12fc fc!e";
            int wait = 12;

            int res = ds.ConvertStringToInt(str);
            Assert.AreEqual(wait, res);

        }
    }
}