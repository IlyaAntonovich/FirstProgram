using System;
using System.Globalization;

/*
 * Задание 4. Напишите программу, проверяющая число введённое с клавиатуры на чётность.
 */

namespace Homework_4
{
    class Homework_4
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

        // Проверка на чётность
        static void Parity_Check(ref bool result, double value)
        {
            double temp = value % 2;
            bool result1 = temp == 0;

            if (result1)
            {
                Console.WriteLine("Число " + "<" + value + "> чётное");
            }
            else
            {
                Console.WriteLine("Число " + "<" + value + "> не чётное");
            }
        }

        static void Main(string[] args)
        {
            double firstValue = 0;
            bool result = false;

            Console.WriteLine("Задание 4. Напишите программу, проверяющая число введённое с клавиатуры на чётность.\n");
            Con_Read_double(ref firstValue, nameof(firstValue));
            Parity_Check(ref result, firstValue);
        }
    }
}
