using System;
using System.Globalization;

/* 
 * ОПЕРАТОРЫ (операнды)
 * 
 * Арифметические операции с числами
 * 
 * ref - ссылка
 * 
 * solution - решение связанный
 * 
 * Решение "Програма_Имя" / Cвойства / Запускаемый проект
 */

namespace Homework_1
{
    class Homework_1
    {
        // Читаем консоль
        static void Con_Read_double(ref double value, string str_name)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.WriteLine("Введите значение " + str_name);
            value = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);
        }

        // Задание 1. Напишите программу, вычисляющую среднее арифметическое двух чисел.
        static void Arithmetic_Mean()
        {
            double firstValue = 0, secondValue = 0, mean;

            Console.WriteLine("Задание 1. Напишите программу, вычисляющую среднее арифметическое двух чисел.\n");

            Con_Read_double(ref firstValue, nameof(firstValue));
            Con_Read_double(ref secondValue, nameof(secondValue));

            mean = (firstValue + secondValue) / 2;

            Console.WriteLine("\nСреднеарифметическое двух чисел " + firstValue + "; " + secondValue);
            Console.WriteLine("(" + firstValue + " + " + secondValue + ") / 2 = " + mean);
        }

        static void Main(string[] args) // Точка входа
        {
            Arithmetic_Mean();
            Console.ReadLine();
        }
    }
}
