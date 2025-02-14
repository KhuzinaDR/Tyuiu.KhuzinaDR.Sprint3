﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhuzinaDR.Sprint3.Task7.V29.Lib
{
    public class DataService : ISprint3Task7V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - 6, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;

        }
    }
}