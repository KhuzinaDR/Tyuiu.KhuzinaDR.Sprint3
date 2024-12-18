using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhuzinaDR.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                res += Math.Pow(1 / Math.Pow(value, i), 2);
            }
            return Math.Round(res, 3);
        }
    }
}