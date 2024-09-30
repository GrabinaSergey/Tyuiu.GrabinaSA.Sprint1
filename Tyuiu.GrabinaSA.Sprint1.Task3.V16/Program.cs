using Tyuiu.GrabinaSA.Sprint1.Task3.V16.Lib;
namespace Tyuiu.GrabinaSA.Sprint1.Task3.V16
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил Грабина Сергей Александрович | ИСТНб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет и печатает                        *");
            Console.WriteLine("* коэффициент приведенного квадратного уравнения, корнями которого        *");
            Console.WriteLine("* являются введенные пользователем два вещественных числа                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение X1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение X2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Коэф уравнения равен:" + ds.CoeffOfQuadraticEquation(x1,x2));

        }
    }
}
