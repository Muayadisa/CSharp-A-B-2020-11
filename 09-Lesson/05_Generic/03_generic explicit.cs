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
            // Nums<T, S>(int x, int y)
            Nums<int, int>(20, 20);

            // Nums<T, S>(string x, int y)
            Nums<string, int>("Hello", 20);

            // Nums<T, S>(int x, string y)
            Nums<int, string>(20, "Hello");

            /*
                
            x = 20, y = 20
            x = Hello, y = 20
            x = 20, y = Hello


            */

            Console.ReadKey();

        }
    }
}
