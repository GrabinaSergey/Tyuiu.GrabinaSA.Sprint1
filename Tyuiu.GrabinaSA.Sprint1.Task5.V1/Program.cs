﻿using Tyuiu.GrabinaSA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.GrabinaSA.Sprint1.Task5.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Грабина С. А. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил Грабина Сергей Александрович | ИСТНб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Если прочитал то твоя мама будет здорова всю жизнь!                     *");
            Console.WriteLine("* Баребухи                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Растояние между точками: " + ds.DistanceBetweenDots(x1, y1, x2, y2));

            Console.ReadLine();

        }
    }
}
