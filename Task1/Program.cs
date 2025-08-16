using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введём целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. Найдём координаты его четвертой вершины.");

            #region Задаём переменные
            Console.Write("Введите значение для x1: ");
            int x1=Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение для y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение для x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение для y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение для x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите значение для y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            #endregion

            #region Производим проверку на треугольник, исходя из данных и находим 4-ю вершину
            int sideXCheck = (x1 == x2 || x1 == x3 || x2 == x3) ? 1 : 0;
            int sideYCheck = (y1 == y2 || y1 == y3 || y2 == y3) ? 1 : 0;

            if (sideXCheck == 1 && sideYCheck == 1)
            {
                int x4 = (x1 == x2) ? x3 : (x1 == x3) ? x2 : x1;
                int y4 = (y1 == y2) ? y3 : (y1 == y3) ? y2 : y1;

                Console.WriteLine("Координаты четвёртой вершины, исходя из Вашего ввода: {0}, {1}.", x4, y4);
            }

            else
                Console.WriteLine("Это не прямоугольник.");
            #endregion

            Console.WriteLine("Нажмите любую кнопку на клавиатуре для завершения работы программы.");
            Console.ReadKey();
        }
    }
}
