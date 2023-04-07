using System;

/*
 *          Логические опрераторы
 *          
 *          &&  Сокращённое И
 *          ||  Сокращённое ИЛИ
 *          &   И
 *          |   ИЛИ
 *          !   НЕ
 *          
 */
namespace LogicalOperator
{
    class LogicalOperator
    {
        public static bool GetTemperature()
        {
            return false;
        }

        public static bool GetCoolingStatus()
        {
            return true;
        }

        static void Main(string[] args)
        {
            if (GetTemperature() && GetCoolingStatus())
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
            }
            else
            {
                Console.WriteLine("Более менее");
            }
        }
    }
}
