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
