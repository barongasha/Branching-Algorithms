# Алгоритмы с ветвлением.

Задание 1. Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. Найти координаты его четвертой вершины. Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами, параллельными координатным осям, вывести соответствующее сообщение.

Решение: 
```
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
```
Задание 2: На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) расположена ближе к A, и вывести эту точку и ее расстояние от точки A. Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А, совпадать с А или между собой - выдать соответствующее сообщение.

Решение: 
```
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

```

Задание 3: 
Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.

Решение: 
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число в диапазоне 20–69, определяющее возраст (в годах). Программа выведет строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год».");

            #region Задаём переменные
            int userAge = Convert.ToInt32(Console.ReadLine());
            int tensOfANumber = userAge / 10;
            int unitsAndYearsOfTheNumber = userAge % 10;

            string tensString = "";
            string unitsString = "";
            string yearsString = "";
            #endregion

            #region Задаём правила написания, исходя из предоставленного года рождения
            if (userAge >= 20 && userAge <= 69)
            {
                // Обрабатываем десятки от введённого числа
                switch (tensOfANumber)
                {
                    case 2:
                        tensString = "двадцать";
                        break;
                    case 3:
                        tensString = "тридцать";
                        break;
                    case 4:
                        tensString = "сорок";
                        break;
                    case 5:
                        tensString = "пятьдесят";
                        break;
                    case 6:
                        tensString = "шестьдесят";
                        break;
                }

                // Обрабатываем единицы от введённого числа и год для корректности вывода
                switch (unitsAndYearsOfTheNumber)
                {
                    case 1:
                        unitsString = "один";
                        yearsString = "год";
                        break;
                    case 2:
                        unitsString = "два";
                        yearsString = "года";
                        break;
                    case 3:
                        unitsString = "три";
                        yearsString = "года";
                        break;
                    case 4:
                        unitsString = "четыре";
                        yearsString = "года";
                        break;
                    case 5:
                        unitsString = "пять";
                        yearsString = "лет";
                        break;
                    case 6:
                        unitsString = "шесть";
                        yearsString = "лет";
                        break;
                    case 7:
                        unitsString = "семь";
                        yearsString = "лет";
                        break;
                    case 8:
                        unitsString = "восемь";
                        yearsString = "лет";
                        break;
                    case 9:
                        unitsString = "девять";
                        yearsString = "лет";
                        break;
                    default:
                        yearsString = "лет";
                        break;
                }

                if (unitsAndYearsOfTheNumber == 0)
                    Console.WriteLine("Вам {0} {1}.", tensString, yearsString);

                else
                Console.WriteLine("Вам {0} {1} {2}.", tensString, unitsString, yearsString);
            }

            else
                Console.WriteLine("Введённое Вами число не подходит для критерия возраста. Принимаются числа только от 20 до 69 лет.");
            #endregion
        }
    }
}

```

Задание 4:
Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке. 

Решение:
```
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число в диапазоне 100–999. Программа выведет строку-описание данного числа.");

            #region Задаём переменные
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int hundredsPart = userNumber / 100;
            int tensPart = (userNumber / 10) % 10;
            int unitsPart = userNumber % 10;
            int lastTwoDigits = userNumber % 100;


            string hundredsString = "";
            string tensString = "";
            string unitsString = "";
            #endregion

            #region Обрабатываем число и выводим корректный ответ в зависимости от заданного числа
            if (userNumber >= 100 && userNumber <= 999)
            {
                /* Из-за большого количества кейсов принял решение для удобочитаемости записать их в одну строку
                Далее обрабатываем сотни от введённого числа */
                switch (hundredsPart)
                {
                    case 1: hundredsString = "сто"; break;
                    case 2: hundredsString = "двести"; break;
                    case 3: hundredsString = "триста"; break;
                    case 4: hundredsString = "четыреста"; break;
                    case 5: hundredsString = "пятьсот"; break;
                    case 6: hundredsString = "шестьсот"; break;
                    case 7: hundredsString = "семьсот"; break;
                    case 8: hundredsString = "восемьсот"; break;
                    case 9: hundredsString = "девятьсот"; break;
                }

                // Обрабатываем десятки и числа от 11 до 19 от введённого числа
                if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
                {
                    switch (lastTwoDigits)
                    {
                        case 11: tensString = "одиннадцать"; break;
                        case 12: tensString = "двенадцать"; break;
                        case 13: tensString = "тринадцать"; break;
                        case 14: tensString = "четырнадцать"; break;
                        case 15: tensString = "пятнадцать"; break;
                        case 16: tensString = "шестнадцать"; break;
                        case 17: tensString = "семнадцать"; break;
                        case 18: tensString = "восемнадцать"; break;
                        case 19: tensString = "девятнадцать"; break;
                    }
                }

                else {
                    switch (tensPart)
                    {
                        case 2: tensString = "двадцать"; break;
                        case 3: tensString = "тридцать"; break;
                        case 4: tensString = "сорок"; break;
                        case 5: tensString = "пятьдесят"; break;
                        case 6: tensString = "шестьдесят"; break;
                        case 7: tensString = "семьдесят"; break;
                        case 8: tensString = "восемьдесят"; break;
                        case 9: tensString = "девяносто"; break;
                    }

                    switch (unitsPart)
                    {
                        case 1: unitsString = "один"; break;
                        case 2: unitsString = "два"; break;
                        case 3: unitsString = "три"; break;
                        case 4: unitsString = "четыре"; break;
                        case 5: unitsString = "пять"; break;
                        case 6: unitsString = "шесть"; break;
                        case 7: unitsString = "семь"; break;
                        case 8: unitsString = "восемь"; break;
                        case 9: unitsString = "девять"; break;
                    }
                }

                if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
                    Console.WriteLine("Ваше число равно: {0} {1}.", hundredsString, tensString);

                else if (tensString == "")
                    Console.WriteLine("Ваше число равно: {0} {1}.", hundredsString, unitsString);

                else if (unitsString == "")
                    Console.WriteLine("Ваше число равно: {0} {1}.", hundredsString, tensString);

                else
                    Console.WriteLine("Ваше число равно: {0} {1} {2}.", hundredsString, tensString, unitsString);
            }
            else
                Console.WriteLine("Введённое значение не входит в диапазон требуемых чисел из условия.");
            #endregion
        }
    }
}

```
