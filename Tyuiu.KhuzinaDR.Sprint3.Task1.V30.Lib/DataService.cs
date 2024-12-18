using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhuzinaDR.Sprint3.Task1.V30.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            while (startValue <= stopValue)
            {
                SumSeries += (Math.Pow(value, startValue) + (5.0 / (startValue + 4))) * (Math.Sin(value));
                startValue++;
            }
            return Math.Round(SumSeries, 3);

        }
    }
}