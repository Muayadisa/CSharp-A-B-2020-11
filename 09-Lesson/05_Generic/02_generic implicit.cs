using System;

namespace Lesson09
{
    class Program
    {

        static void Nums<T, S>(T x, S y)
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }

        static void Main(string[] args)
        {
            Nums(20, 20);
            Nums("Hello", 20);
            Nums(20, "Hello");

            /*
                
            x = 20, y = 20
            x = Hello, y = 20
            x = 20, y = Hello


            */

            Console.ReadKey();

        }
    }
}
