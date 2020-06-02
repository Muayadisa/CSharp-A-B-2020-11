using System;

namespace Lesson09
{
    class Program
    {

        static void Nums<T>(T x, T y)
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }

        static void Main(string[] args)
        {

            Nums(5, 8);
            Nums("Hello", "generic");
            Nums(true, false);
            Nums(4.3, 2.7);

            /*
                x = 5, y = 8
                x = Hello, y = generic
                x = True, y = False
                x = 4.3, y = 2.7
            */
        }
    }
}
