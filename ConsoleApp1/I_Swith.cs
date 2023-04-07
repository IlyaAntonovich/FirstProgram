using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        public static double DoOperation(double value1, double value2, string op)
        {
            double result = double.NaN; // NaN - значение пусто

            switch (op)
            { 
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "/":
                    if (value2 != 0) // Не делим на 0
                    {
                        result = value1 / value2;
                    }
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            bool endApp = false;

            // Заголовок
            Console.WriteLine("Калькулятор в консоли на С#\r"); // \r - что бы установить курсор ввода в начало этой строки.
            Console.WriteLine("---------------------------\n");

            while(!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.WriteLine("Введите число numInput1 и нажмите Enter: \r");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("Это недопустимое значение numInput1. Пожалуйста введите целое (int) значение numInput1: \r");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Введите число numInput2 и нажмите Enter:");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("Это недопустимое значение numInput2. Пожалуйста введите целое (int) значение numInput2: \r");
                    numInput2 = Console.ReadLine();
                }

                // Попросить пользователя выбрать оператор
                Console.WriteLine("Выбирите и введите нужный опреатор из списка:");
                Console.WriteLine("\t+");
                Console.WriteLine("\t-");
                Console.WriteLine("\t*");
                Console.WriteLine("\t/");
                Console.WriteLine("Ваш выбор? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if(double.IsNaN(result))
                    {
                        Console.WriteLine("Эта операция привела к ошибке!\n");
                    }
                    else
                    {
                        Console.WriteLine("Ваш результат: {0:0.##}\n", result);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("О нет! При попытке выполнить операцию возникло исключение.");
                    Console.WriteLine("Подробности: " + e.Message);
                }
                
                Console.WriteLine("---------------------------\n");

                // Перед закрытием ожидаем команды пользователя
                Console.WriteLine("Введите 'n' чтобы завершить работу");
                Console.WriteLine("Введите что-то другое чтобы продолжить работу");

                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }

                Console.WriteLine("\n"); // Удобное расположение строк
            }
        }
    }
}
