using System;

namespace Lesson09
{
    class Calculator
    {
        // Method Add() with 2 int arguments
        public void Add(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        // Method Add() with 3 int arguments
        public void Add(int x, int y, int z)
        {
            Console.WriteLine($"{x} + {y} + {z} = {x + y + z}");
        }

        // Method Add() with 2 string arguments
        public void Add(string x, string y)
        {
            string res = x + y;

            Console.WriteLine($"{x} + {y} = {res}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.Add(5, 7);
            c1.Add(4, 7, 1);

            c1.Add("Hello", " World");

        }
    }
}
