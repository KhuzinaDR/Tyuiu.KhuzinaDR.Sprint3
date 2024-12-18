using Tyuiu.KhuzinaDR.Sprint3.Task1.V30.Lib;
namespace Tyuiu.KhuzinaDR.Sprint3.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Хузина Д. Р. | СМАРТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #30                                                                  *");
            Console.WriteLine("* Выполнила: Хузина Диана Ранидовна | СМАРТб-24-1                       *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда по     *");
            Console.WriteLine("* формуле, при t=0,5                                                           *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int startValue = 1;
            int stopValue = 12;
            double value = 0.5;
            Console.WriteLine("Переменная t = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();

        }
    }
}