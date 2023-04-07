using System;
/*
 * Инкремент и декремент. Постфиксный и префиксный
 */
namespace IncDecPostPre
{
    class IncDecPostPre
    {
        static void Main(string[] args)
        {
            int a = 0;

            a++; // Постфиксный
            Console.WriteLine(a);

            ++a; // Префиксный
            Console.WriteLine(a);

            a = 1;
            a = ++a * a;
            Console.WriteLine(a);
        }
    }
}
