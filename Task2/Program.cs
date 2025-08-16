using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("На числовой оси расположены три точки: A, B, C. Задайте их и программа выведет самую близкую точку к A. Если B и C будут равноостоящими от А, то замечание будет выведено.");

            #region Задаём переменные
            Console.Write("Введите координату точки A: ");
            int coordinateOfPointA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату точки B: ");
            int coordinateOfPointB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату точки C: ");
            int coordinateOfPointC = Convert.ToInt32(Console.ReadLine());

            int distanceB = Math.Abs(coordinateOfPointA - coordinateOfPointB);
            int distanceC = Math.Abs(coordinateOfPointA - coordinateOfPointC);
            #endregion

            #region Проводим вычисления по нахождению самой близкой точке к точке А. Если они равноотдалены - будет соответствующий ответ
            
            if (coordinateOfPointB == coordinateOfPointC)
            {
                if (coordinateOfPointB == coordinateOfPointA)
                    Console.WriteLine("Все три точки совпадают в точке {0}.", coordinateOfPointA);

                else
                    Console.WriteLine("Точки B и C совпадают в координате {0}. Расстояние до точки A: {1} единиц.", coordinateOfPointB, distanceB);
            }

            else if (coordinateOfPointA == coordinateOfPointB)
                Console.WriteLine("Точка B совпадает с точкой A (координата {0}). Расстояние от точки C до точки A: {1} единиц.", coordinateOfPointA, distanceC);

            else if (coordinateOfPointA == coordinateOfPointC)
                Console.WriteLine("Точка C совпадает с точкой A (координата {0}). Расстояние от точки B до точки A: {1} единиц.", coordinateOfPointA, distanceB);

            else if (distanceC == distanceB)
                Console.WriteLine("Точка B с координатой в точке {0} и точка C с координатой в точке {1} равноотдалены от точки А с координатой в точке {2}. Их разница от точки А составляет {3} единиц.", coordinateOfPointB, coordinateOfPointC, coordinateOfPointA, distanceC);

            else if (distanceB < distanceC)
                Console.WriteLine("Точка B с координатой в точке {0} ближе к точке A с координатой в точке {1}, чем точка C с координатой в точке {2}. Расстояние точки B к точке А составляет {3} единиц.", coordinateOfPointB, coordinateOfPointA, coordinateOfPointC, distanceB);

            else
                Console.WriteLine("Точка C с координатой в точке {0} ближе к точке A с координатой в точке {1}, чем точка B с координатой в точке {2}. Расстояние точки С к точке А составляет {3} единиц.", coordinateOfPointC, coordinateOfPointA, coordinateOfPointB, distanceC);
            #endregion

            Console.ReadKey();
        }
    }
}
