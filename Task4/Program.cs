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
