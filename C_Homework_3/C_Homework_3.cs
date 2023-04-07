using System;
using System.Globalization;

namespace Homework_3
{
    class Homework_3
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

        /*
        * Задание 3. Напишите простой конвертер валют (без возможности динамического выбора валюты пользователем).
        * Валюты заданы хардкодом и не меняются. Тип валют на выбор программиста.
        */
        static void UsdTo()
        {
            double UsdToRubs = 66.29, UsdToUah = 27.24, USD = 0;

            Console.WriteLine("Задание 3. Напишите простой конвертер валют (без возможности динамического выбора валюты пользователем).\n" +
                              "Валюты заданы хардкодом и не меняются. Тип валют на выбор программиста.\n");

            Con_Read_double(ref USD, nameof(USD));

            Console.WriteLine(USD + " $ в RUB = " + (USD * UsdToRubs));
            Console.WriteLine(USD + " $ в UAH = " + (USD * UsdToUah));
        }

        static void Main(string[] args)
        {
            UsdTo();
            Console.ReadLine();
        }
    }
}
