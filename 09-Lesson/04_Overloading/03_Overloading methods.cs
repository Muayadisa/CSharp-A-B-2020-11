using System;

namespace Lesson09
{
    class Program
    {
        // overloading with two int variables:
        static bool isEqual(int x, int y)
        {
            return x == y;
        }

        // overloading with two string variables:
        static bool isEqual(string x, string y)
        {
            return x == y;
        }

        // overloading with two double variables:
        static bool isEqual(double x, double y)
        {
            return x == y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isEqual(3, 6));             // False
            Console.WriteLine(isEqual(3.7, 6.42));        // False
            Console.WriteLine(isEqual("hello", "hello")); // True

            Console.ReadKey();

        }
    }
}
