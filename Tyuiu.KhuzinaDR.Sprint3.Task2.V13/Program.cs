using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.KhuzinaDR.Sprint3.Task2.V13.Lib;

namespace Tyuiu.KhuzinaDR.Sprint3.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Хузина Д. Р. | СМАРТб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Варинант #13                                                            *");
            Console.WriteLine("* Выполнила: Хузина Диана Ранидовна | СМАРТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет сумму*****");
            Console.WriteLine("*ряда по формуле, при t=0,7************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Переменная X = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadLine();
        }
    }
}