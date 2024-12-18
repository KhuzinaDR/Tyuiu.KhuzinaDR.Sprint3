using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.KhuzinaDR.Sprint3.Task2.V13.Lib;

namespace Tyuiu.KhuzinaDR.Sprint3.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 2.105;
            Assert.AreEqual(wait, res);
        }
    }
}