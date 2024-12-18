using Tyuiu.KhuzinaDR.Sprint3.Task0.V11.Lib;

namespace Tyuiu.KhuzinDR.Sprint3.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n;
            int startValue;
            int stopValue;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n = " + n);
            startValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("startValue = " + startValue);
            stopValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSeries(n, startValue, stopValue));
        }
    }
}