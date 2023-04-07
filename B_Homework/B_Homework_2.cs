using System;
using System.Globalization;

namespace Homework_2
{
    class Homework_2
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

        // Задание 2. Введите три числа и выведите на экран значение суммы и произведения этих чисел.
        static void Sum_Mult_3num()
        {
            double firstValue = 0, secondValue = 0, thridValue = 0, sumResult, multResult;

            Console.WriteLine("Задание 2.Введите три числа и выведите на экран значение суммы и произведения этих чисел.\n");

            Con_Read_double(ref firstValue, nameof(firstValue));
            Con_Read_double(ref secondValue, nameof(secondValue));
            Con_Read_double(ref thridValue, nameof(thridValue));

            sumResult = firstValue + secondValue + thridValue;
            multResult = firstValue * secondValue * thridValue;
            Console.WriteLine("\nСумма\nfirstValue + secondValue + thridValue = " + firstValue + " + " + secondValue + " + " + thridValue + " = " + sumResult);
            Console.WriteLine("\nПроизведение\nfirstValue * secondValue * thridValue = " + firstValue + " * " + secondValue + " * " + thridValue + " = " + multResult + "\n");

            multResult = firstValue * secondValue * thridValue;
        }
        static void Main(string[] args)
        {
            Sum_Mult_3num();
            Console.ReadLine();
        }
    }
}
