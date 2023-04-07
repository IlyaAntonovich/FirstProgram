using System;

/*
 * Операторы отношений
 * Операции сравнения
 */

/*
 *          == Равно
 *          != Не равно
 *          > Больше
 *          < Меньше
 *          >= Больше или равно
 *          <= Меньше или равно
 */
namespace RelationCompartion
{
    class RelationCompartion
    {
        static void Main(string[] args)
        {
            int a, b;
            bool result;

            a = 5; b = 3;
            Console.WriteLine(" a = " + a + "\tb = " + b + "\n");

            result = a == b;
            Console.WriteLine(" a == b\t" + result);

            result = a != b;
            Console.WriteLine(" a != b\t" + result);

            result = a > b;
            Console.WriteLine(" a > b\t" + result);

            result = a < b;
            Console.WriteLine(" a < b\t" + result);

            result = a >= b;
            Console.WriteLine(" a >= b\t" + result);

            result = a <= b;
            Console.WriteLine(" a <= b\t" + result);
        }
    }
}
