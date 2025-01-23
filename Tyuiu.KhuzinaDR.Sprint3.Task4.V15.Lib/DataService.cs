using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KhuzinaDR.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            double x;
            stopValue = 5;
            for (x = -5; x <= stopValue; x++)
            {
                if (x != 0)
                {
                    res = res * (((Math.Sin(x) + x) / (x)) + 0.75);
                }
                if (x == 0)
                    continue;
            }
            return Math.Round(res, 3);
        }
    }
}